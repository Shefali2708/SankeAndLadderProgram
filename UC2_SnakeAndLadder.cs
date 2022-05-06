using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderProgram
{
    //The Player rolls the die to get a number between 1 to 6.
    //- Use((RANDOM)) to get the number between 1 to 6
    class UC2_SnakeAndLadder
    {
        public static void Start_Game_UC2()
        {
            //VARIABLE
            int Player_Position = 0;

            Random randomNum = new Random();
            int DiceRolled = randomNum.Next(1, 7);
            Player_Position = Player_Position + DiceRolled;

            Console.WriteLine("Player Position : {0}", Player_Position);
        }
    }
}
