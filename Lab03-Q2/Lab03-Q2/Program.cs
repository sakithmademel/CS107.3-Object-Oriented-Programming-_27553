using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an upper limit: ");
            string uLimitStr = Console.ReadLine();
            int uLimit = Convert.ToInt32(uLimitStr);


            int sum = 0;


            for (int i = 1; i <= uLimit; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("The sum of all the odd numbers from 1 to {0} is {1}.", uLimit, sum);
        }
    }
}
