using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    class Program
    {
        static void Main(string[] args)
        {
            string RollAgain = "null";
            Console.WriteLine("This programs rolls a six sided die. would you like to roll it?(Yes or No)");
            string roll = Console.ReadLine();
            string LowCRoll = roll.ToLower();
            if ( LowCRoll == "yes" || LowCRoll == "y")
            {
                Console.WriteLine("Rolling...");
                RollAgain = "1";
            }
            else
            {
                Console.WriteLine("Closing program");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            while (RollAgain == "1")
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 7);
                Console.WriteLine("You rolled a:"+ dice);
                Console.WriteLine("would you like to play again?(Yes or No)");
                string UsrChoice = Console.ReadLine();
                String LowCChoice = UsrChoice.ToLower();
                if (LowCChoice == "yes" || LowCChoice == "y")
                {
                    Console.WriteLine("Ok.Rolling again.");
                    RollAgain = "1";
                }
                else
                {
                    Console.WriteLine("Exiting program");
                    RollAgain = "0";
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }
                
        }
    }
}
