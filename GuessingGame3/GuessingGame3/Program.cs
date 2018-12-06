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
            int min = 1;
            int max = 11;
            int againL = 1;
            int againH = 10;
            int count = 0;
            string guessString;
            int guess = 90000;
            string result = null;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            while (guess != randomNumber)
            {
                WriteLine("Choose a number between 1-10. ");
                guessString = ReadLine();
                guess = Convert.ToInt32(guessString);

                if (guess <= 10 && guess >= 1)
                {
                    if (randomNumber == guess)
                    {
                        result = " Congrats on the guess of " + randomNumber;
                    }
                    else if (guess < randomNumber)
                    {
                        result = "You guessed " + guess + " , too low. ";
                        if (guess <= againL)
                        {
                            result = "What?! " + guess + " Why? SMH. ";
                        }
                        againL = guess;
                    }
                    else if (guess > randomNumber)
                    {
                        result = "You guessed to high ";
                        if (guess >= againH)
                        {
                            result = "What?! " + guess + " Why? SMH. ";

                        }
                        againH = guess;
                    }
                    else if (guess < min || guess >= max)
                    {
                        result = " Out of bounds. ";
                    }
                    DisplayString(result);
                }
            }
            
        }
        static void DisplayString(string result)
        {
            WriteLine(result);
        }
    }
}

/*
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
            */
