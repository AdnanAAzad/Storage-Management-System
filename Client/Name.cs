using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
        }
        private void ConnectBTN_Click(object sender, EventArgs e)
        {
            string name = AddressTxt.Text;
            ClientApp client = new ClientApp(name);
            this.Hide();
            client.ShowDialog();
            /*
             * loop on a single thread is not a valid operation. Use Form.ShowDialog instead.'
             * */
            this.Close();
        }
        private void NameTxt_KeyPress(object sender, KeyPressEventArgs e) // pressing enter
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ConnectBTN_Click(sender, e);
            }
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_Load(object sender, EventArgs e)
        {
            AddressTxt.Text = "0.0.0.0:4545";
        }
    }
}
