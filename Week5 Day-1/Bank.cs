using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Day_1
{
    internal class Bank
    {
        private double balance = 2500;

        public double Balance
        {
            get { return balance; }
            set
            {
                balance = value;
            }

        }
        public void Deposit(double amount)
        {
            Balance += amount;
            GetBalance();
        }
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficent Balance");
            }
            else
            {
                Balance -= amount;
                GetBalance();
            }
        }

        public void GetBalance()
        {
            Console.WriteLine($"Final Balance : {balance}");
        }
    }
}
