using System;
using Week4_Day_5;

namespace Week4_Day_5
{
    internal class BankAccount
    {

        private double balance;

        public BankAccount(double initialBalance =0)
        {

            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Amount Deposited : " + balance);
            }
            else
                Console.WriteLine("Amount cant be deposited");   
        }
        
        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine("Amount withdrawl successfully");
            }
            else
                Console.WriteLine("Insufficient balance");

        }
        public double GetBalance()
        {
            return balance;
        }

    }
}
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.Deposit(1000);
        account.Withdraw(300);
        Console.WriteLine($"Current Balance = {account.GetBalance()}");
    }
}