using System;

namespace Bank_App
{
    public class Bank
    {
        private int Pin;

        private string AccountNumber;

        private double AccountBalance;
       

        public void CheckPin()
        {
            int trials = 3;

            int pin = 1234;
            
            do
            {
                Console.WriteLine("Enter your pin:");

                Pin = Convert.ToInt32(Console.ReadLine());

                if(Pin == pin)
                {
                    Console.WriteLine("Welcome to F Z bank");
                    Menu();
                }
                else
                {
                   if(trials > 1)
                   {
                       Console.WriteLine($"You have {--trials} trials left..");
                   }
                   else
                   {
                       Console.WriteLine("Account barred!");
                       break;
                   }
                }

            } while (pin != Pin);          
           
        }


        private void AmountToTransfer()
        {
            AccountBalance = 10000000000000000;

            double amount;

            do
            {
                Console.WriteLine("Enter the amount you want to transfer");
                amount = Convert.ToDouble(Console.ReadLine());

                 double bankCharges = BankCharges(amount);

                 double totalCharges = AdditionOfTotalCharges(amount, bankCharges);

                 if (amount >= 50)
                 {
                     if (amount >= AccountBalance || totalCharges >= AccountBalance)
                     {
                         Console.WriteLine("You have insufficient fund");
                     }
                     else
                     {
                        TransferBreakDown(amount, bankCharges);

                        Console.WriteLine("Enter recipient's account number");

                        string userAccountNumber = Console.ReadLine();

                        bool accountNumberCheck = CheckAccountNumberValidity(userAccountNumber);

                        if(accountNumberCheck)
                        {
                            double newBalance = DeductAmountFromBalance(amount, bankCharges);
                            Console.WriteLine("Transfer was succesfull");
                            Console.WriteLine($"Your balance is: {newBalance}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid recipient Account Number.....E pada sile yin sir/ma..");
                        }
                     }
                 }
                 else
                 {
                     Console.WriteLine("Invalid amount... Enter a valid amount!");
                 }
            } while (amount <= 0 || amount < 50);
           

        }

        private bool CheckAccountNumberValidity(string accountNumber)
        {
            bool accountNumberIsValid = true;

            AccountNumber = "2004173344";

            if(accountNumber == null || accountNumber != AccountNumber)
            {
                accountNumberIsValid = false;
            }

            return accountNumberIsValid;
        }

        private double BankCharges(double amount)
        {
            double bankCharges = amount * 1 / 100;

            return bankCharges;
        }

        private double AdditionOfTotalCharges(double amount, double charges)
        {
            double totalCharges = amount + charges;

            return totalCharges;
        }
    
        private double DeductAmountFromBalance(double amount, double bankCharges)
        {
            double newBalance1 = AccountBalance - (amount + bankCharges);

            return newBalance1;
        }

        private void TransferBreakDown(double amount, double charges)
        {
            double bankCharges = BankCharges(amount);

            double totalAmount = bankCharges + amount;

            Console.WriteLine($"Amount to transfer: {amount}");
            Console.WriteLine();

            Console.WriteLine($"Bank Charges: {bankCharges}");
            Console.WriteLine();

            Console.WriteLine($"Total: {totalAmount}");
        }
        private void WithdrawalMethod()
        {
            AccountBalance = 10000000000000000;

            double amount;

            do
            {
                Console.WriteLine("Enter the amount you want to withdraw");
                amount = Convert.ToDouble(Console.ReadLine());

                double bankCharges = BankCharges(amount);

                double totalCharges = AdditionOfTotalCharges(amount, bankCharges);

                if (amount >= 50)
                {
                    if (amount >= AccountBalance || totalCharges >= AccountBalance)
                    {
                        Console.WriteLine("You have insufficient fund");
                    }
                    else
                    {
                        Console.WriteLine("Take your cash.....");
                        double newBalance = AccountBalance - amount ;

                        Console.WriteLine($"Your balance is: {newBalance}");
                        
                    }
                }
                else
                {
                    Console.WriteLine("Invalid amount... Enter a valid amount!");
                }
            } while (amount <= 0 || amount < 50);


        }

        private void CheckBalance()
        {
            AccountBalance = 1000000000;

            
           Console.WriteLine($"Your account balance is {AccountBalance}");
        }
        private void AnotherTransaction()
        {
            bool check = true;
            Console.WriteLine("Do you want to perform another transaction???...... Yes or no..??");
            Console.ReadLine();
           
            if(check == true)
            {
                ShowMenu();
            }
            else
            {
                Console.WriteLine("Thanks for banking with us");
            }
        }
        private void Menu()
        {
            bool check = true;
            do
            {
                
                ShowMenu();

                string option = Console.ReadLine();

                if (option == "0")
                {
                    check = false;
                    Console.WriteLine("Thank you For using our bank");
                }
                else if(option == "1")
                {
                    AmountToTransfer();
                    AnotherTransaction();
                }
                else if(option == "2")
                {
                    WithdrawalMethod();
                    AnotherTransaction();
                }
                else if(option == "3")
                {
                    CheckBalance();
                    AnotherTransaction();
                }
                else
                {
                    AnotherTransaction();
                }


            } while (check);

        
        }

        public static void ShowMenu()
        {
            
            Console.WriteLine("1. Transfer");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("0. Exit");
        }



    }

}
