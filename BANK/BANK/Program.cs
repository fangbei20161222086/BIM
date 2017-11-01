using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BANK
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount;
            double add;                               
            Console.WriteLine("Welcome to CS110 BANK ");
            Console.Write("What is your bank id? ");
            string id=Console.ReadLine();
            Console.Write("Initial deposit into Checking:");
            string de = Console.ReadLine();
            amount = Convert.ToDouble(de);
            Console.Write("Initial deposit into Saving:");
            string s = Console.ReadLine();
            add = Convert.ToDouble(s);
            Console.WriteLine("Command Options");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("a: deposit");
            Console.WriteLine("b: withdraw");
            Console.WriteLine("c: display the balance");
            Console.WriteLine("d: Check the account");
            Console.WriteLine("?: display the menu again ");
            Console.WriteLine("q: quit this program");
            bool w = true;
            while (w)
            {
                Console.WriteLine("Please enter a command or type ? ");
                char sel=Convert.ToChar(Console.ReadLine());
                switch (sel)
                {
                    case 'a':
                        {
                            Console.WriteLine("Amount to deposit: ");
                            double sav = Convert.ToDouble(Console.ReadLine());
                            amount += sav;
                            Console.WriteLine("You deposited ${0:N} to Checking.", sav);
                        }
                        break;

                    case 'b':
                        {
                            Console.WriteLine("Amount to withdraw: ");
                            double sav = Convert.ToDouble(Console.ReadLine());
                            amount -= sav;
                            if (amount < 0)
                            {
                                Console.WriteLine("Invalid choice (not sufficient fund)");
                                amount += sav;
                                break;
                            }
                            else
                                Console.WriteLine("You withdrew ${0:N}", sav);
                            break;
                        }
                    case 'c':
                        {
                            Console.WriteLine("ID:{0}", id);
                            Console.WriteLine("Checking Balance: ${0:N}", amount);
                            Console.WriteLine("Saving Balance: ${0:N}", add);
                            break;
                        }

                    case 'd':
                        {
                            Console.WriteLine("What is your bank id? ");
                            string i = Console.ReadLine();
                            if (i == id)
                            {
                                Console.WriteLine("Here is the balance: ID:{0}", id);
                                Console.WriteLine("Checking Balance: ${0:N}", amount);
                                Console.WriteLine("Saving Balance: ${0:N}", add);
                                break;
                            }
                            else
                                Console.WriteLine("Wrong ID!");
                            break;
                        }

                    case 'q':
                        {
                            Console.WriteLine("ID:{0}", id);
                            Console.WriteLine("Checking Balance: ${0:N}", amount);
                            Console.WriteLine("Saving Balance: ${0:N}", add);
                            w = false;
                            break;
                        }

                    case '?':
                        {
                            Console.WriteLine("Command Options");
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine("a: deposit");
                            Console.WriteLine("b: withdraw");
                            Console.WriteLine("c: display the balance");
                            Console.WriteLine("d: Check the account");
                            Console.WriteLine("?: display the menu again ");
                            Console.WriteLine("q: quit this program");
                            break;
                        }
                }
            }
       }
    }
}
