using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returnasdigitlist
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("please type in a number no longer than 10 digits");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("Original number:" + num);
            char numbers = Convert.ToChar(num);
            Console.ReadKey();
        }
    }
}
