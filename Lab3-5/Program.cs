using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_5
{
    class Program
    {
        static void Main(string[] args)
        {

            CashRegister cr1 = new CashRegister();

            Console.WriteLine("Adding an item worth 2.70 to cash register 1");
            Console.WriteLine("Adding an item worth 3.45 to cash register 1");
            Console.WriteLine("Adding an item worth 5.97 to cash register 1");
            Console.WriteLine("Adding an item worth 17.99 to cash register 1");
            Console.WriteLine("Adding an item worth 5.99 to cash register 1");
            cr1.AddItem(2.70);
            cr1.AddItem(3.45);
            cr1.AddItem(5.97);
            cr1.AddItem(17.99);
            cr1.AddItem(5.99);


            CashRegister cr2 = new CashRegister();

            Console.WriteLine("Adding an item worth 2.90 to cash register 2");
            Console.WriteLine("Adding an item worth 3.10 to cash register 2");
            Console.WriteLine("Adding an item worth 15.50 to cash register 2");
            cr2.AddItem(2.90);
            cr2.AddItem(3.10);
            cr2.AddItem(15.50);



            Console.WriteLine("Cash register CR1 Total: {0}", cr1.Total);
            Console.WriteLine("Cash Register CR1 Number of Items: {0}", cr1.NumberOfItems);
            Console.WriteLine("Cash register CR2 Total: {0}", cr2.Total);
            Console.WriteLine("Cash Register CR2 Number of Items: {0}", cr2.NumberOfItems);


        }
    }
}
