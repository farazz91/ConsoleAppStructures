using System;

namespace ConsoleAppStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer(101, "Sarfaraz");
            cust1.printCustomerDetails();
            Console.WriteLine();

            Customer cust2 = new Customer();
            cust2.ID = 102;
            cust2.Name = "Faraz";
            cust2.printCustomerDetails();
            Console.WriteLine();

            Customer cust3 = new Customer() { ID = 103, Name = "Sarf" };
            cust3.printCustomerDetails();
        }
    }
}
