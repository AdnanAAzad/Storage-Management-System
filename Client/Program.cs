using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class ProgramInfo : System.Attribute
    {
        private string developer;
        private int ID;
        private string message;
        // constructor
        public ProgramInfo(string developer, int ID, string message)
        {
            this.developer = developer;
            this.ID = ID;
            this.message = message;
        }

        // properties
        public string Developer
        {
            get
            {
                return this.developer;
            }
        }
        public int ProgramID
        {
            get
            {
                return this.ID;
            }
        }
        public string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                message = value;
            }
        }
    }

    [ProgramInfo("Adnan Azad", 001, "Created on: Aug 4, 2020")]
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new Name()); // run name
        }

        static void getStart(TcpClient temp, string name)
        {
            ClientApp ChartObj = new ClientApp(name + " Server Side", temp);
            try
            {
                Application.Run(ChartObj);
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            temp.Close();
            Console.WriteLine(string.Format("Connecting from {0} is closed at {1}", name, DateTime.Now));
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(typeof(Program));
        }
    }
}
