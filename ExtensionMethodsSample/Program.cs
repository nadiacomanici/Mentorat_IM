using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// include extension
using ExtensionMethodsSample.Helpers;

namespace ExtensionMethodsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar: ");

            string input = Console.ReadLine();
            if (input.IsNumeric())
            {
                Console.WriteLine("Ati introdus un numar valid.");
            }
            else
            {
                Console.WriteLine("Nu ati introdus un numar valid.");
            }

            // extension methods for lists
            List<int> list = new List<int>() { 1, 2, 34, 5 };
            var min = list.Min();
        }
    }
}
