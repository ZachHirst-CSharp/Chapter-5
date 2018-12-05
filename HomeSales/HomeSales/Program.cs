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
            string userlogin, saleslogin, money, Dmoney, Emoney, Fmoney;
            double D_total = 0, D_add = 0, E_total = 0, E_add = 0, F_total = 0, F_add = 0;
            double salestotal = 0;

            WriteLine("Please use an Initial to log onto the computer.");
            userlogin = ReadLine();

            int ticktotal = 0, tickD = 0, tickE = 0, tickF = 0;

            do
            {
                WriteLine("Who would you like to log sales for? ");
                saleslogin = ReadLine();
                if (saleslogin == "D" || saleslogin == "d")
                {
                    ++tickD;
                    WriteLine("What is the amount sold? ");
                    D_add = Convert.ToDouble(ReadLine());
                    D_total += D_add;
                }
                else if (saleslogin == "E" || saleslogin == "e")
                {
                    ++tickE;
                    WriteLine("What is the amount sold? ");
                    E_add = Convert.ToDouble(ReadLine());
                    E_total += E_add;
                }
                else if (saleslogin == "F" || saleslogin == "f")
                {
                    ++tickF;
                    WriteLine("What is the amount sold? ");
                    F_add = Convert.ToDouble(ReadLine());
                    F_total += F_add;
                }
                else if (saleslogin == "Z" || saleslogin == "z")
                {
                    //do nothing 
                }
                else
                {
                    WriteLine("Error, the initial you entered is invalid please try again. ");
                }
            } while (saleslogin != "Z" && saleslogin != "z");

            ticktotal = tickF + tickE + tickD;
            salestotal = D_total + E_total + F_total;
            

            WriteLine("The grand total of all sales $" + salestotal);
            WriteLine();
            WriteLine("The total for salesman D is $" + D_total);
            WriteLine();
            WriteLine("The total for salesman E is $" + E_total);
            WriteLine();
            WriteLine("The total for salesman F is $" + F_total);
            WriteLine();
            WriteLine("The total number of sales was " + ticktotal + " sales.");
            WriteLine();

            if(D_total > E_total && D_total > F_total)
            {
                WriteLine("The highest salesman was Danielle with $" + D_total);
                WriteLine("She had " + tickD + " sale(s). ");
            }
            else if(E_total > D_total && E_total > F_total)
            {
                WriteLine("The highest salesman was Edward with " + E_total);
                WriteLine("He had " + tickE + " sale(s). ");
            }
            else if(F_total > E_total && F_total > D_total)
            {
                WriteLine("The highest salesman was Francis with " + F_total);
                WriteLine("She had " + tickF + " sale(s). ");
            }
            else
            {
                WriteLine("There was a tie!");
            }
        }
    }
}
