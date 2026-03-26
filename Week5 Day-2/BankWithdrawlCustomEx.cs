using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Day_2
{
    internal class BankWithdrawlCustomEx(String message): Exception(message)
        {

        }
        class Bank
        {
            private double balance = 2500;
            public void withdraw(double amount)
            {
                try
                {
                    if (amount > balance)
                    {
                        throw new BankWithdrawlCustomEx("Insuffecient Balance Exception.");
                    }
                    else
                    {
                        balance -= amount;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    display();
                }
            }
            public void display()
            {
                Console.WriteLine(balance);
            }
        }
        internal class BankImplementation
        {

            static void Main()
            {
                Bank b = new Bank();

                Console.WriteLine("Enter amount : ");
                int amount = Convert.ToInt32(Console.ReadLine());

                b.withdraw(amount);

            }

        }
    }

