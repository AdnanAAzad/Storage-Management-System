using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using Server;

namespace PRG650_LAB5_Server
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

            TcpListener listener = new TcpListener(4545);
            listener.Start();
            Console.WriteLine("Waiting for Client");
            TcpClient client = listener.AcceptTcpClient();

            // how to obtain data between client and server
            byte[] bytes = new byte[1024];
            NetworkStream ns = client.GetStream();
            int bytesRead = ns.Read(bytes, 0, bytes.Length);
            string name = Encoding.ASCII.GetString(bytes, 0, bytesRead);

            Console.WriteLine(string.Format("Connecting to {0}, at {1}", name, DateTime.Now));
            Thread thread = new Thread(() => getStart(client, name));
            thread.Start();
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(typeof(Program));
        }

        static void getStart(TcpClient temp, string name)
        {
            ServerStorage ChartObj = new ServerStorage(name + " Server Side", temp); // temp is the tcp client
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
            Console.WriteLine(string.Format("Connection from {0} is closed at {1}", name, DateTime.Now));
        }
    }
}
