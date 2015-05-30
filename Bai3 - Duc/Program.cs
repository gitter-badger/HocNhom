using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3___Duc
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            string i = "";
            
            do
            {
                Console.Write("Input 1 to input a character or 2 for break: ");
                i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        Console.Write("Enter a character: ");
                        c = Convert.ToChar(Console.ReadLine());

                        if (c == 'u' || c == 'e' || c == 'o' || c == 'a' || c == 'i')
                        {
                            Console.WriteLine(c + " is a vowel.");
                        }
                        else
                        {
                            Console.WriteLine(c + " is a consonant.");
                        }
                        break;
                    case "2":
                        break;
                }
                
            } while (i != "2");
           

               
                





            

            Console.ReadLine();
        }
    }
}
