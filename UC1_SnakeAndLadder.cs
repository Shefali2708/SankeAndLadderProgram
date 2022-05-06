using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderProgram
{
    //Snake and Ladder game played with single player at start position 0
    class UC1_SnakeAndLadder
    {
        //Variable
        public int Player_Position = 0;

        public void Start_Game()
        {
            Console.WriteLine(" ----- Game Started ----- ");
            Console.WriteLine("Number of Player is Single PLayer");
            Console.WriteLine("Player Position : {0}", Player_Position);
        }
    }
}
