using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;

            Console.WriteLine("sum: " +sum);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
