using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// question 1
/// c#
/// </summary>
namespace greeneexamquestion1
{
    class Program
    {
        public static List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public static List<int> loseit(List<int> list)
        {

            list.RemoveAt(0);
            list.Remove(list[list.Count - 1]);
            return list;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("original list:");
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine("\n");
            Console.WriteLine("list without first and last");
            Console.Write(string.Join(", ", loseit(numbers)));
            Console.WriteLine("\n");
            Console.WriteLine("press anywhere to continue...");
            Console.ReadKey();
        }
    }
}
