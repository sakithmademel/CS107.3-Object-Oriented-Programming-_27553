using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            string firstNumberStr = Console.ReadLine();
            int num1 = Convert.ToInt32(firstNumberStr);

            Console.WriteLine("Enter the second number: ");
            string secondNumberStr = Console.ReadLine();
            int num2 = Convert.ToInt32(secondNumberStr);

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            float div = num1 / num2;

            Console.WriteLine("The sum of the two numbers is: " + sum);
            Console.WriteLine("The difference of the two numbers is: " + difference);
            Console.WriteLine("The product of the two numbers is: " + product);
            Console.WriteLine("The quotient of the two numbers is: " + div);
        }
    }
}
