using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EnterLowercaseLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_input;

            do
            {
                WriteLine("Please enter lowercase letters. ");
                WriteLine();
                WriteLine("To exit please enter a ! ");
                user_input = ReadLine();
                char letter = Convert.ToChar(user_input);
                if(letter >= 'a' && letter <= 'z')
                {
                    WriteLine("OK");
                }
                else
                {
                    WriteLine("ERROR please enter a lowercase letter.");
                }
            } while (user_input != "!");
        }
    }
}
