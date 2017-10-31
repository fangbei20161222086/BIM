using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c;
            string[] name=new string[3];
            int w=0;
            Console.WriteLine("Please input the first name:");
            a = Console.ReadLine();
            char[] m=a.ToCharArray();
            if (m[0] >= 'A' && m[0] <= 'z')
            {
                string n1 = string.Empty;
                n1=a.Substring(0, 1).ToUpper()+a.Substring(1);
                name[w++]=n1;
                Console.WriteLine("{0} is the first name.", n1);
            }
            else
            {
                Console.WriteLine("Error: The first name was not accepted.");
               
            }
            Console.WriteLine("Please input the second name:");
            b = Console.ReadLine();
            char[] n = b.ToCharArray();
            if (n[0] >= 'A' && n[0] <= 'z')
            {
                string n2 = string.Empty;
                n2 = b.Substring(0, 1).ToUpper() + b.Substring(1);
                name[w++] = n2; 
                Console.WriteLine("{0} is the second name.", n2);
            }
            else
            {
                Console.WriteLine("Error: The second name was not accepted.");
              
            }
            Console.WriteLine("Please input the third name:");
            c = Console.ReadLine();
            char[] p = c.ToCharArray();
            if (p[0] >= 'A' && p[0] <= 'z')
            {
                string n3 = string.Empty;
                n3 = c.Substring(0, 1).ToUpper() + c.Substring(1);
                name[w++] = n3; 
                Console.WriteLine("{0} is the third name.", n3);
            }
            else
            {
                Console.WriteLine("Error: The third name was not accepted.");
            }
           
            string temp;
            for (int i = 0; i < w-1; i++)
            {
                for (int j = 0; j < w-i-1; j++)
                {
                    if (name[j].CompareTo(name[j+1])==1)
                    {
                        temp = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = temp;
                    }
                }   
            }
            Console.WriteLine("The names in alphabetical order are: ");
            for (int i = 0; i < w; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
