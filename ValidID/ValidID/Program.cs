using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ValidID
{
    class Program
    {
        static void Main(string[] args)
        {
            int idnum;
            string input;
            const int LOW = 1000;
            const int HIGH = 9999;

            WriteLine("Enter an ID number");
            input = ReadLine();
            idnum = Convert.ToInt32(input);

            while (idnum < LOW || idnum > HIGH)
            {
                WriteLine(idnum + " Is an invalid ID number");
                WriteLine(" ID numbers must be between " + LOW + " & " + HIGH);
                WriteLine("Enter an ID number");
                input = ReadLine();
                idnum = Convert.ToInt32(input);
            }

            WriteLine("ID Number " + idnum + " is valid. ");
            ReadKey();
        }
    }
}
