using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SumForInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            const int MAX = 4;
            string inputString;

            for(int i = 0; i < MAX; i++)
            {
                WriteLine("Enter a number. ");
                num = Convert.ToInt32(ReadLine());
                sum = sum + num;
            }

            WriteLine("the sum is " + sum);
        }
    }
}
