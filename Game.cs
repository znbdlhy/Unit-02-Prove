using System;
using System.Collections.Generic;

namespace Hilo_Game
{

    public class Director
    {
        bool isPlaying = true;
        int totalPoints = 300;
        string guess = "";
        public Director()
        {
        }

        public void StartGame()
        {
            while (isPlaying)
            {
                Game();
                Display();
            }
        }

        public void Game()
        {
            Card card1 = new Card();
            Console.WriteLine($"The card is: {card1.value}.");
            Console.WriteLine("Higher or Lower? [h/l] ");
            guess = Console.ReadLine();
            Card card2 = new Card();
            Console.WriteLine($"The new card is: {card2.value}.");

            if (guess == "h" && card2.value > card1.value)
            {
                totalPoints += 100;
            }

            else if (guess == "l" && card2.value < card1.value)
            {
                totalPoints += 100;
            }

            else
            {
                totalPoints -= 75;
            }

        }
        public void Display()
        {
            if (totalPoints <= 0)
            {
                Console.Write("GameOver");
                isPlaying = false;
            }

            else if (totalPoints > 0)
            {
                Console.WriteLine($"The score is: {totalPoints}. ");
                Console.WriteLine($"Do you want to play again? [y/n] ");
                string playAgain = Console.ReadLine();

                if (playAgain == "y")
                {
                    isPlaying = true;
                }

                if (playAgain == "n")
                {
                    isPlaying = false;
                }
            }
        }
    }
}