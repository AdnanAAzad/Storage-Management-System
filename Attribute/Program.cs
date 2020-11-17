using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
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

    [ProgramInfo("Adnan", 001, "Created on: Aug 4, 2020")]
    public class NewClass { }
    public class Program
    {
        static void Main(string[] args)
        {
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(typeof(NewClass));
            Console.ReadKey();
        }
    }
}
