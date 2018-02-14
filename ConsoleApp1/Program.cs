using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("please enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int x = num1; x <= num2; x++)            
            {
                sum += x;
                Console.WriteLine(sum);
                
            }
            stopWatch.Stop();
            
            TimeSpan ts = stopWatch.Elapsed; 
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.ReadKey();
        }

    }
}
