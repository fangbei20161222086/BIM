using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount n1 = new BankAccount();                           
            Console.WriteLine("Welcome to CS110 BANK ");
            Console.Write("What is your bank id? ");
            string ID=Console.ReadLine();
            n1.setID(ID);
            Console.Write("Initial deposit into Checking:");
            string de = Console.ReadLine();
            double che = Convert.ToDouble(de);
            n1.Checking = che;
            Console.Write("Initial deposit into Saving:");
            string s = Console.ReadLine();
            double add = Convert.ToDouble(s);
            n1.Saving = add;
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
                            n1.Checking += sav;
                            Console.WriteLine("You deposited ${0:N} to Checking.", sav);
                        }
                        break;

                    case 'b':
                        {
                            Console.WriteLine("Amount to withdraw: ");
                            double sav = Convert.ToDouble(Console.ReadLine());
                            n1.Checking -= sav;
                            if (n1.Checking < 0)
                            {
                                Console.WriteLine("Invalid choice (not sufficient fund)");
                                n1.Checking += sav;
                                break;
                            }
                            else
                                Console.WriteLine("You withdrew ${0:N}", sav);
                            break;
                        }
                    case 'c':
                        {
                            n1.display();
                            break;
                        }

                    case 'd':
                        {
                            Console.WriteLine("What is your bank id? ");
                            string i = Console.ReadLine();
                            if (i == n1.getID())
                            {
                                Console.WriteLine("Here is the balance: ");
                                n1.display();
                                break;
                            }
                            else
                                Console.WriteLine("Wrong ID!");
                            break;
                        }

                    case 'q':
                        {

                            n1.addInterest();
                            n1.display();
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
