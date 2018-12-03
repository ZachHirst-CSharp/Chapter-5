using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SumInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;

            do
            {
                WriteLine("Please enter a number. ");
                WriteLine();
                WriteLine("To exit please enter 9999");
                num = Convert.ToInt32(ReadLine());
                sum += num;
                WriteLine("The sum is " + sum);
                
            } while (num != 9999);
        }
    }
}
