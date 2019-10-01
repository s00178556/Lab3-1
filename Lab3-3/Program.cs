﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BankAccount acc1 = new BankAccount("11114444", "Tom Smith", 1000);
            BankAccount acc2 = new BankAccount("22222555", "Mary Mills", 2000);

            Console.WriteLine(acc1.GetAccountDetails());
            Console.WriteLine(acc2.GetAccountDetails());

            Console.WriteLine("Adding 1000 to account 1");
            acc1.Deposit(1000);
            Console.WriteLine(acc1.GetAccountDetails());

            Console.WriteLine("Withdrawing from account 2");
            acc2.WithDraw(500);
            Console.WriteLine(acc2.GetAccountDetails());

        }
    }
}
