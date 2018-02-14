using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. solve for x");
            Console.WriteLine("please choose a number.");
            Console.Write("number:");
            string choice =  Console.ReadLine();
            if (choice == "1")
            {
                SolveForX();
            }
            else
            {
                Console.WriteLine("please choose a correct number");
                

            }
        }
        static void SolveForX()
        {
            Console.WriteLine("1");
            Console.ReadKey();
        }

    }
}

