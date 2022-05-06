using System;

namespace SnakeAndLadderProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Snake And Ladder Game !");

            //Snake and Ladder game played with single player at start position 0
            UC1_SnakeAndLadder GameUC1 = new UC1_SnakeAndLadder();
            GameUC1.Start_Game_UC1();

            //The Player rolls the die to get a number between 1 to 6.
            //- Use((RANDOM)) to get the number between 1 to 6
            UC2_SnakeAndLadder.Start_Game_UC2();





        }
    }
}
