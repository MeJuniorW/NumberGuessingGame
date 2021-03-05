using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomInt = new Random();
            Console.WriteLine("Guess a number between 1 and 20");
            int guessNum = randomInt.Next(1, 21);
            bool gameOver = false;

            void GuessGame()
            {
                while (gameOver != true)
                {
                    int playerInput = Convert.ToInt32(Console.ReadLine());
                    if (guessNum < playerInput)
                    {
                        Console.WriteLine("Too high");
                    }
                    else if (guessNum > playerInput)
                    {
                        Console.WriteLine("Too low");
                    }
                    else if (guessNum == playerInput)
                    {
                        Console.WriteLine("correct");
                        gameOver = true;
                    }
                }
            }
            GuessGame();
        }
    }
}