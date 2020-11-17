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


namespace Server
{
    public partial class ServerStorage : Form
    {
        
        delegate void SetTextCallback(string text);
        private string name;
        private TcpClient client;
        private NetworkStream ns;
        private Thread t = null;
        public ServerStorage()
        {
            InitializeComponent();
        }

        public ServerStorage(string name)
        {
            InitializeComponent();
            this.name = name;
            this.Text = name;
        }

        public ServerStorage(string name, TcpClient client) : this(name)
        {
            this.client = client;
            ns = this.client.GetStream();
            t = new Thread(Fun);
            t.Start();
        }
        public void Fun()
        {
            byte[] bytes = new byte[1024]; // buffer, get text from network
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
        private void SetText(string text)
        {
            if (this.StorageBox.InvokeRequired)
            {
                SetTextCallback del = new SetTextCallback(SetText);
                try
                {
                    this.Invoke(del, new object[] { text });
                    string client_text = text;

                }
                catch (System.ObjectDisposedException)
                {
                    //this.Close();
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Close();
                    });
                }

            }
            else // RECIEVING DATA INTO STORAGE
            {
                if (text.Length == 1) // RETRIEVE - 1 length string that means only an index value came through
                {
                    this.StorageBox.Items.RemoveAt(Int32.Parse(text)); // remove item at index value
                    UpdateStorage();

                }
                else if (Int32.TryParse(text[0].ToString(), out int _)) // MOdify item at index
                {
                    int index = Int32.Parse(text[0].ToString());
                    string ModData = text.Substring(1);
                    StorageBox.Items.RemoveAt(index);
                    StorageBox.Items.Insert(index, ModData);
                    UpdateStorage();

                }
                else  // ADD - if not index value, add to the storage
                {
                    this.StorageBox.Items.Insert(0, text);
                    UpdateStorage();


                }

            }
        }
        private void UpdateStorage()
        {
            // This function is used to clear all text box fields
            NumStorage.Text = StorageBox.Items.Count.ToString();
        }
        private void StorageBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ServerStorage_Load(object sender, EventArgs e)
        {
            UpdateStorage();
        }
    }
}
