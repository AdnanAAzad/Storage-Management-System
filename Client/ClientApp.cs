using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Runtime.Serialization.Formatters;

namespace Client
{
    public partial class ClientApp : Form
    {
        delegate void SetTextCallback(string text);
        public string name;
        private TcpClient client;
        private NetworkStream ns;
        private Thread t = null;
        private const string Host_Name = "localhost";
        private const int Port = 4545;


        public ClientApp()
        {
            InitializeComponent();
            client = new TcpClient(Host_Name, Port);
            ns = client.GetStream();
            this.name = "Client1";
            byte[] byteTime = Encoding.ASCII.GetBytes(name);
            ns.Write(byteTime, 0, byteTime.Length);
            t = new Thread(Fun);
            t.Start();
            this.ActiveControl = NameTxt;
            NameTxt.Focus();
        }
        public ClientApp(string name)
        {
            InitializeComponent();
            client = new TcpClient(Host_Name, Port);
            ns = client.GetStream();
            this.Text = name + " Client Side";
            this.name = name;
            byte[] byteTime = Encoding.ASCII.GetBytes(name);
            ns.Write(byteTime, 0, byteTime.Length);
            t = new Thread(Fun);
            t.Start();
            ClearAllFields();
            this.ActiveControl = NameTxt;
            NameTxt.Focus();
        }
        public ClientApp(string name, TcpClient client)  : this(name)
        {
            this.client = client;
            ns = this.client.GetStream();
            t = new Thread(Fun);
            t.Start();
            ClearAllFields();
        }
        public void Fun()
        {
            byte[] bytes = new byte[1024];
            while (true)
            {
                try
                {
                    int bytesRead = ns.Read(bytes, 0, bytes.Length);
                    this.SetText(Encoding.ASCII.GetString(bytes, 0, bytesRead));
                }
                catch (System.IO.IOException ex)
                {
                    break;
                    throw ex;
                }
            }
        }
        private void SetText(string text) // list box sync over TCP/IP
        {
            if (this.StorageBox.InvokeRequired)
            {
                SetTextCallback del = new SetTextCallback(SetText);
                try
                {
                    this.Invoke(del, new object[] { text });
                }
                catch (System.ObjectDisposedException)
                {
                    this.Close();
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Close();
                    });
                }
            }
            else // if everything is in check, add to list box
            {
                //this.StorageBox.Items.Add(text);
                this.StorageBox.Items.Insert(0, text);
            }
        }

        private void StoreBTN_Click(object sender, EventArgs e) // ADD FUNCTIONALITY
        {
            String UserName = NameTxt.Text.ToLower();
            String item = SendTxt.Text.ToLower(); 
            if (NameTxt.Text == "" | SendTxt.Text == "" | NameTxt.Text.Any(char.IsDigit))// Check if fields are empty.
            {
                // if empty then show message to enter values
                MessageBox.Show("Please Properly Fill in the following fields: Name, Item.\nAnd Name Must be Valid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAllFields();
            }
            else
            {
                // if fields are properly written, then send it to storage
                String s = ($"{UserName}:{item}"); // sends just text
                byte[] byteTime = Encoding.ASCII.GetBytes(s);
                ns.Write(byteTime, 0, byteTime.Length);
                SetText(s);
                ClearAllFields();
            }
        }
        
        private void RetrieveBTN_Click(object sender, EventArgs e) // REMOVE FUNCTIONALITY
        {
            // This button click event removes the item selected from the storage box
            if (StorageBox.SelectedIndex < 0) // if no item is selected
            {
                // Send message to select an item before trying to retrieve it
                MessageBox.Show("No Item Has Been Selected!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAllFields();
            }
            else // item is selected from storage
            {
                string RetrievedItem = StorageBox.SelectedIndex.ToString(); // this is the index converted to string!!
                // send selected index to server to remove the item at index value
                byte[] byteTime = Encoding.ASCII.GetBytes(RetrievedItem);
                ns.Write(byteTime, 0, byteTime.Length);
                StorageBox.Items.RemoveAt(StorageBox.SelectedIndex); // removes this list box, not servers
                ClearAllFields();
                MessageBox.Show("Item Succesfully Retrieved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e) // SEARCH FUNCTIONALITY
        {
            // This is used to bring up searched item into the search list box.
            SearchBoxRes.Items.Clear(); // clear search list box results at every instance
            string ToFind = SearchBox.Text.ToLower();
            if (SearchBox.Text == "") // empty search condition
            {
                //MessageBox.Show("Please Fill in the Search Box");
                SearchBoxRes.Items.Clear();
            }
            else // searching storage
            {
                // loop through storage items and activly bring up items that has a match
                foreach (string s in StorageBox.Items)
                {
                    if (s.Contains(ToFind))
                        SearchBoxRes.Items.Add(s);
                }
            }
        }
        private void ModBTN_Click(object sender, EventArgs e) // MODIFY FUNCTIONALITY
        {
            // This button changes the name of item

            int index = StorageBox.SelectedIndex;

            if (index < 0) // Nothing selected, throw error
            {
                MessageBox.Show("Please Select an Item to Modify", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAllFields();
            }
            else // fields are filled: make changes
            {
                // convert the selected item into string
                string sample = StorageBox.SelectedItem.ToString();
                // find string index where ':' is
                int str_index = sample.IndexOf(":");
                // Split name and item into two strings
                string sampleName = sample.Substring(0, str_index); // include 0 -> index
                string sampleItem = sample.Substring(str_index + 1); // include index -> end

                if (ModUserNameBox.Text == "" & ModItemNameBox.Text == "") // if both text fields are empty: throw error
                {
                    MessageBox.Show("Please Enter the Fild You Wish to Modify", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearAllFields();
                }
                else if (ModUserNameBox.Text == "") // if only item being changed
                {
                    // get the item name user put for modification
                    string ModifiedStr = ($"{sampleName}:{ModItemNameBox.Text.ToLower()}");
                    Modify(index, ModifiedStr);
                }
                else if (ModItemNameBox.Text == "") // if only name being changed
                {
                    // get the name the user put for modification
                    string ModifiedStr = ($"{ModUserNameBox.Text.ToLower()}:{sampleItem}");
                    Modify(index, ModifiedStr);
                }
                else // both name and item will be changed
                {
                    string ModifiedStr = ($"{ModUserNameBox.Text.ToLower()}:{ModItemNameBox.Text.ToLower()}");
                    Modify(index, ModifiedStr);
                }
            }
        }
        private void Modify(int index, string ModifiedStr) // modify functionality support method
        {
            // this function modifies the item with the server
            StorageBox.Items.RemoveAt(index);
            StorageBox.Items.Insert(index, ModifiedStr); // modify item with new name and item name
                                                         // send item changes to server
            String s = ($"{index}{ModifiedStr}");
            byte[] byteTime = Encoding.ASCII.GetBytes(s);
            ns.Write(byteTime, 0, byteTime.Length);
            MessageBox.Show("Change Successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAllFields();

        }
        public void ClearAllFields()
        {
            // This function is used to clear all text box fields
            NumItemLbl.Text = StorageBox.Items.Count.ToString();
            SendTxt.Clear();
            NameTxt.Clear();
            ModItemNameBox.Clear();
            ModUserNameBox.Clear();
            SearchBox.Clear();
        }
        private void SimulateBTN_Click(object sender, EventArgs e) // TO DEMO AND POPULATE STORAGE BOX
        {
            // create a loop to loop through and add names and random items to the storage for simulation
            int i = 0;
            string[] DemoNames = new string[] { "adnan", "david", "john", "billy", "jonson" , "harold" , "tiffany", "lou","xin", "mary","trevor",
                "bernard", "josh","Isla","Olivia","Aurora","Ada","Charlotte","Amara","Maeve","Cora","Amelia","Posie","Luna","Ophelia","Ava","Rose","Eleanor","Genevieve","Alice","Elodie","Lucy",
                "Ivy","Evelyn","Astrid","Freya","Anna","Iris","Mia","Violet","Eloise","Aurelia","Thea","Adelaide","Maisie","Esme","Nora","Adah","Chloe","Emilia","Jane","Aria",
                "Penelope","Maya","Hazel","Adeline","Elizabeth",
                "Julia","Claire","Josephine","Lilith","Beatrice","Willa","Caroline","Anastasia","Grace","Elena","Abigail","Clementine","Mabel","Willow","Sadie","Isabel","Wren",
                "Stella","Lydia","Emily","Seraphine","Margot","Mila","Gabriella","Gemma","Matilda","Naomi","Poppy","Lila","Margaret","Madeline","Cleo","Hannah","Elliana","Zara",
                "Cordelia","Maya","Delilah","Harper","Ottilie","Sienna","Lily","Florence" }; // 113 names

            string[] DemoItems = new string[] { "chair", "keyboard" , "Acer Monitor" , "table" , "hot tub","coffee", "Ikea Couch", "Air Conditioner",
                "Camera Equipment", "Microphone", "Fan", "Weights", "GTX 1070 Video Card","onesies","shirts","envelope","pants","pajamas","rompers","sweaters","jackets","socks","booties","hats","cap","mittens","blankets","suit","bag","stroller","detergent","Crib","cradle","bassinet",
                "mattress","monitor","chair","glider","cloths","towels","brush","Dishwasher","pads","pillow","cloths","thermometer","pacifiers","swing","mat","Knife","Board",
                "Cup","Spoons","Bowls","Colander","Whisk","Grater","Rod","Skillet","pot","pan","Saucepan","Sheet","Muffin","Stockpot","Spatula","Tongs","Ladle","Oven","Blender","Scale","Container","Paper","pencil",
                "book","Tray","noodles","coffee","tea","mug","clips","lego","sharpeners","erasers","computer","laptop","phone","toothbrush","card","candle","Mirror","Lantern","Flower","Ribbon","Photobooth","Balloon",
                "Postbox","Cookie","cameras","ladder" }; // 13

            //loop through and add into storage
            do
            {
                NameTxt.Text = DemoNames[i];
                SendTxt.Text = DemoItems[i];
                StoreBTN.PerformClick();
                i++;
                System.Threading.Thread.Sleep(1);
            } while (i < DemoNames.Length);
        }
        private void ClientApp_Load(object sender, EventArgs e)
        {

        }
        
        // Enter press key changes
        private void NameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendTxt.Focus();
            }
        }

        private void SendTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StoreBTN.PerformClick();
            }
        }

        private void ModUserNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ModItemNameBox.Focus();
            }
        }

        private void ModItemNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ModBTN.PerformClick();
            }
        }
    }
}
