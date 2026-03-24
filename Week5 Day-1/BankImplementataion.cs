using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Day_1
{
    internal class BankImplementataion
    {
        static double Amount()
        {
            Console.Write("Enter Amount : ");
            double amount = Convert.ToDouble(Console.ReadLine());
            return amount;
        }
        static void Main()
        {
            double amount;
            Console.Write("1.ShowBalance\n2.Deposit\n3.Withdraw\nEnter operation : ");
            byte operation = Convert.ToByte(Console.ReadLine());
            Bank bank = new Bank();

            switch (operation)
            {
                case 1:
                    bank.GetBalance();
                    break;
                case 2:
                    amount = Amount();
                    bank.Withdraw(amount);
                    break;
                case 3:
                    amount = Amount();
                    bank.Deposit(amount);
                    break;
                default:
                    Console.WriteLine("Enter only 1,2,3");
                    break;
            }
        }
    }
}
