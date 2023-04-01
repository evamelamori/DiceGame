using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace Dice_Game
{
    class DiceGame
    {
        private string GameName;
        private Random RandomGenerator;
        private int Score;

        public DiceGame()
        {
            // Initialize anything that we need to:
            Score = 0;
            GameName = "Dice Rolling Game";
            RandomGenerator = new Random();
        }

        public void Start()
        {
            // Method that starts the game running.
            Title = GameName;
            WriteLine($"=== {GameName} ===");
            WriteLine("\nLet's play a game of chance with dice.");
            WriteLine("\nInstructions");
            WriteLine("\t> I will roll a dice each round.");
            WriteLine("\t> You will guess if it is high or low.");
            WriteLine("\t> If you get it right, I'll give you a point.");
            WriteLine("\n Ready to play? (yes/no)");
            

            string playResponse = ReadLine().Trim().ToLower();
            if (playResponse == "yes") 
            {
                WriteLine("Great - let's play!");
                PlayRound();
            }
            else
            {
                WriteLine("Okay, maybe next time...");
            }


            WriteLine("Press any key to exit...");
            ReadKey();
        }

        private void PlayRound()
        {
            // Method that runs one rounf of rolling and guessing.
            Clear();
            WriteLine("I am about to roll...");
            WriteLine("Is it going to be low (1, 2, 3) or high (4, 5, 6)?");

            string response = ReadLine().Trim().ToLower();


            int roll = RandomGenerator.Next(1, 7);
            WriteLine($"The roll was {roll}.");

            if (response == "high")
            {
                WriteLine("You guessed high...");
                if (roll <= 3)
                {
                    Lose();
                }
                else
                {
                    Win();
                }
            }
            else if (response == "low")
            {
                WriteLine("You guessed low...");
                if (roll <= 3)
                {
                    Win();
                }
                else
                {
                    Lose();
                }
            }
            else
            {
                WriteLine($"You guessed '{response}'. That is not valid, try again with 'high' or 'low'");

            }
            AskToPlayAgain();
        }


        private void Win()
        {
            Score = Score + 1;
            WriteLine("You win!");
            WriteLine($"Your score:{Score}.");

            // Method that increments the score and lets player know they won.
        }

        private void Lose()
        {
            // Method that lets player know they lose.
            WriteLine("You loose!");

        }

        private void AskToPlayAgain()
        {
            // Method that asks the player if they want to play another round.
            WriteLine("Would you like to play another round? (yes/no)");
            string playResponse = ReadLine().ToLower().Trim();
            if (playResponse == "yes")
            {
                PlayRound();
            }
            else
            {
                WriteLine("Sad... But see you next time.");
            }
        }

    }
}
