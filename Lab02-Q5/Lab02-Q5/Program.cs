using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] uInputs = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number: ");
                string numStr = Console.ReadLine();
                int num = Convert.ToInt32(numStr);
                uInputs[i] = num;
            }

            for (int i = 0; i < 10; i++)
            {
                bool even = (uInputs[i] % 2 == 0);
                if (even)
                {
                    Console.WriteLine("The number {0} is even.", uInputs[i]);
                }
                else
                {
                    Console.WriteLine("The number {0} is odd.", uInputs[i]);
                }
            }
    }
}
