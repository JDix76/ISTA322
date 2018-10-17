using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameMachine
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play a game computer! Can you guess my number between 1 - 100");

            int start = 1;
            int end = 100;
            int cpuGuess = (start + end) / 2;

            Guess(cpuGuess, start, end);
        }

        private static void Guess(int cpuGuess, int start, int end)
        {
            Console.WriteLine("User input commands: higher, lower, and bingo");
            Console.WriteLine($"My guess is: {cpuGuess}");
            string answer = Console.ReadLine();

            if (answer == "lower")
            {
                end = cpuGuess - 1;
                cpuGuess = (end + start) / 2;
                Guess(cpuGuess, start, end);
            }
            else if (answer == "higher")
            {
                start = cpuGuess + 1;
                cpuGuess = (start + end) / 2;
                Guess(cpuGuess, start, end);
            }
            else if (answer == "bingo")
            {
                Console.WriteLine("Congrats!");
            }

        }
    }
}

    
           

    
        
    
        
    

