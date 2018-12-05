using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OddNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while(num <= 99)
            {
                WriteLine(" " + num);

                num += 2;
            }
        }
    }
}
