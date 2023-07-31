using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("The sum of the two numbers is: " + sum);

            Console.ReadLine();
        }
    }
}
