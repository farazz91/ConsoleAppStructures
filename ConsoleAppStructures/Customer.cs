using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStructures
{
    struct Customer
    {
        private int id;
        private string name;

        public int ID { 
            get { return this.id; } 
            set { this.id = value; } 
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Customer(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void printCustomerDetails()
        {
            Console.WriteLine("Customer Id: {0}",this.id);
            Console.WriteLine("Customer Name: {0}", this.name);
        }
    }
}
