using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp136
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("please enter an integer numerator:");
            var numerator = int.Parse(Console.ReadLine());

            Console.Write("please enter an integer denominator:");
            var denominator = int.Parse(Console.ReadLine());


            var result = numerator / denominator;

            Console.WriteLine($"\nResult:{numerator}/{denominator}={result}");
                
            Console.ReadLine();
        }
    }
}

