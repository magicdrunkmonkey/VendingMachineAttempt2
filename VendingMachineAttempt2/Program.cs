using System;

namespace VendingMachineAttempt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fields, declare, initialize
            //int moneyPool;                 //Do not know what to do with this yet.

            //readonly int[] moneyValue = { 1, 5, 10, 20, 50, 100, 1000 };   //Why does this not work?
                    
            //Console.WriteLine("Hello World!");
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
        //Return unused money left in the moneypool
        public void EndTransaction()
        {
            throw new NotImplementedException();
        }

        //Add money to the moneypool.
        public void InsertMoney()
        {            
            throw new NotImplementedException();
        }

        //To purchase a product from the vendingmachine
        //with money from the moneypool.
        public void Purchase()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }

        //Show all available products with prices
        //that the vendingmachine have.
        public void ShowAll()
        {
            throw new NotImplementedException();
        }
    }
}
