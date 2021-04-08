using System;

namespace Bank_App
{
    class Program
    { 
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            bank.CheckPin();
        }
    }
}