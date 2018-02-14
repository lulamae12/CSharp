using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello there! my name bob, what is yours?");
            string playername = Console.ReadLine();
            Console.WriteLine("hello there, " + playername);
            Console.WriteLine("Would you like to add or subtract two numbers?");
            string playerchoice = Console.ReadLine();
            if (playerchoice is ("add"))
            {
                Addition();
            }
            if (playerchoice is ("subtract"))
            {
                Subtraction();
            }
        }
        static void Addition()
        {
            int firstnumber;
            int secondnumber;
            Console.WriteLine("please enter your first number");
            firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your second number");
            secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(firstnumber + " + " + secondnumber + " = " + (firstnumber + secondnumber));
            Console.WriteLine("press a key to exit");
            Console.ReadKey();
        }
        static void Subtraction()
        {
            int firstnumber;
            int secondnumber;
            Console.WriteLine("please enter your first number");
            firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your second number");
            secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( firstnumber + " - " + secondnumber + " = " + (firstnumber - secondnumber));
            Console.WriteLine("press a key to exit");
            Console.ReadKey();
        }
    }

    
}
