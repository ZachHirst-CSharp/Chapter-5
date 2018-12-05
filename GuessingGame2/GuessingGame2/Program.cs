using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomgenerator = new Random();

            int userguess, randomnum;

            randomnum = randomgenerator.Next(1, 11);

            do
            {
                WriteLine("Please guess the random number. (1-10) ");
                userguess = Convert.ToInt32(ReadLine());

                if(userguess > randomnum)
                {
                    WriteLine("Your guess was too high! ");
                }
                else if(userguess < randomnum)
                {
                    WriteLine("Your guess was too low. ");
                }
                else if(userguess < 1 || userguess > 10)
                {
                    WriteLine("Please enter a number within the game barriers please. ");
                }
                else
                {
                    //nothing 
                }
            } while (userguess != randomnum);

            WriteLine("Congrats you won. ");
        }
    }
}
