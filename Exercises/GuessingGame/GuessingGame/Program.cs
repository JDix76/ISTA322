using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 1000);
            int guess = 0;
            int numberOfGuesses = 10;
            bool correct = false;

            Console.WriteLine("Let's play a game! Pick a number between 1 and 1000:");
            Console.WriteLine();
            Console.WriteLine("Please input your guess: ");

            while (correct == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses--;


                if (guess != randomNumber && numberOfGuesses == 0)
                {
           
                    Console.WriteLine("Ooops, I forgot to tell you that you only had 10 tries...hahaha..YOU LOSE!!");
                    correct = true;
                }

                else if (guess == randomNumber)
                {
                    Console.WriteLine("You guess the right number...CONGRATS!!!");
                    correct = true;
                }

                else if (guess > randomNumber)
                {
                    Console.WriteLine("Sorry! The number is lower than that.");
                } 
                else if (guess < randomNumber)
                    Console.WriteLine("Nope! The number is higher than that.");
            
            }


        }
    }
}
