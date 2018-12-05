using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuessingGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomgenerator = new Random();

            int userguess, randomnum, guessdummy;

            randomnum = randomgenerator.Next(1, 11);
            int pgH = 10;
            int pgL = 1;

            do
            {

                WriteLine("Please guess the random number. (1-10) ");
                userguess = Convert.ToInt32(ReadLine());

                if (userguess > randomnum)
                {
                    if(pgH > userguess)
                    {
                        WriteLine("TOO High. ");
                        pgH = userguess;
                        if(pgH > userguess)
                        {
                            WriteLine("You're Dumb");
                        }
                        else
                        {
                            WriteLine("Guess again. ");
                        }
                    }
                }
                else if (userguess < randomnum)
                {
                    WriteLine("Your guess was too low. ");
                }
                else if (userguess < 1 || userguess > 10)
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
