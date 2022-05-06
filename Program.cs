using System;

namespace SnakeAndLadderProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Snake and Ladder game played with single player at start position 0
            Console.WriteLine("Hello to Snake And Ladder Game !");

            UC1_SnakeAndLadder GameUC1 = new UC1_SnakeAndLadder();
            GameUC1.Start_Game();
        }
    }
}
