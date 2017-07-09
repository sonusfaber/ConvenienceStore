using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenienceStore
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningTotal = 0;
            bool storeOpen = true;
            int dollars;

            while (storeOpen)
            {
                //prompt to add money
                Console.Write("Enter the amount of money you want to add or type \"quit\" to exit: ");
                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    storeOpen = false;
                    break;
                }

                try
                {
                    dollars = int.Parse(entry);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Input Error, use only valid dollar ammounts!");
                    continue;
                }
                

                if (dollars == 1 || dollars == 2 || dollars == 5 || dollars == 10 || dollars == 20 || dollars == 50 || dollars == 100)
                {
                    //add money to total
                    runningTotal += dollars;

                }
                else
                {
                    Console.WriteLine("Input Error, use only valid dollar ammounts!");
                }

                //show the amount of money
                Console.WriteLine("You put in " + runningTotal + " dollars");

                //repeat until quit
            }


        }
    }
}
