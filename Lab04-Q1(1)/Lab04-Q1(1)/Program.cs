using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Q1_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues obj = new ConvertValues();

            obj.kilometerToMeter();
        }
    }
    class ConvertValues
    {
        public void kilometerToMeter()
        {

            double meter = 1000;

            Console.WriteLine("1 kilometer = " +meter);
        }
    }
}
