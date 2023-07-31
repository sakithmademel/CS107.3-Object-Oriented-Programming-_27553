using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 3.14;

            Console.Write("Enter the radius of the circle: ");
            double r = double.Parse(Console.ReadLine());

            double area = A * r * r;

            Console.WriteLine("The area of the circle is: " + area);

            Console.ReadLine();
        }
    }
}
