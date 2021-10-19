﻿using System;

namespace VendingMachineAttempt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }

    // Interface
    interface IVending
    {
        void Purchase(); // interface method (does not have a body)
        void ShowAll();
        void InsertMoney();
        void EndTransaction();
    }

    // VendingMachine "implements" the IVending interface
    class VendingMachine : IVending
    {
        public void EndTransaction()
        {
            throw new NotImplementedException();
        }

        public void InsertMoney()
        {
            throw new NotImplementedException();
        }

        public void Purchase()
        {
            // The body of animalSound() is provided here 
            Console.WriteLine("The pig says: wee wee");
        }

        public void ShowAll()
        {
            throw new NotImplementedException();
        }
    }
}
