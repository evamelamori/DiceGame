using System;
using static System.Console;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demos to do:
            //- Random 
            //- Id statements
            //- Switch statements

            //Random myRandomGenerator = new Random();
            //int randNumber = myRandomGenerator.Next(1, 7);
            //WriteLine($"A random number for you: {randNumber}.");

            // == !=
            // > >= < <=
            //if (randNumber == 1)
            //{
            //    WriteLine("You got a one - how lucky!");

            //}
            //else
            //{
            //    WriteLine("Dang - you didn't get a one this time.");
            //}

            //if (randNumber <=3)
            // {
            //     WriteLine("You got a low roll!");
            // }
            //else
            // {
            //     WriteLine("You got a high roll!");
            // }




            // WriteLine("Press any key to exit...");

            // ReadKey();


            DiceGame myGame = new DiceGame();
            myGame.Start();

        }
    }
}
