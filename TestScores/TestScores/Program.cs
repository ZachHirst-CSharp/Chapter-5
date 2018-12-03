using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            double score, total = 0, avg;
            int tick = 0;
            const int MIN = 0, MAX = 100;

            do
            {
                WriteLine("Please enter your test score. ");
                WriteLine();
                WriteLine("To exit please enter 150");
                score = Convert.ToDouble(ReadLine());
                
                
                if(score >= MIN && score <= MAX)
                {
                    total += score;
                    tick++;
                    avg = total / tick;
                    WriteLine("The number of scores entered is " + tick);
                    WriteLine("The average is " + avg);
                }
                else if (score < MIN || score > MAX)
                {
                    WriteLine("ERROR Please enter a valid test score. ");
                }

            } while (score != 150);
        }
    }
}
