using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            double salesinput, salestotal, salesD, salesE, salesF;
            string userinput, userD, userE, userF;

            do
            {
                WriteLine("Please enter a sales associate. ");
                userinput = Convert.ToString(ReadLine());
                if(userinput == "Z" && userinput == "z")
                {
                    goto endwhile;
                }
                else
                WriteLine("Please enter a sales amount. ");
                salesinput = Convert.ToDouble(ReadLine());


                endwhile:;
            } while (userinput != "Z" && userinput != "z");

            WriteLine("Hello");
        }
    }
}

