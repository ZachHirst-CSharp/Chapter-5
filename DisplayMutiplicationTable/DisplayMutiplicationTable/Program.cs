using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DisplayMutiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int j= 1, n = 1, result;

            while(j <= 10)
            {
                result = j * n;
                Write(" " + result);
                ++n;
                if (n > 10)
                {
                    n = 1;
                    ++j;
                    WriteLine("");
                }
            }         
        }
    }
}