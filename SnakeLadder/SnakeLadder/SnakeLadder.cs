using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class SnakeLadder
    {
        //public int Position;
        //public int Count;

        //SnakeLadder()
        //{
        //    this.Position = 0;

        //}

        //public static void Random()
        //{
        //    Random dice = new Random();
        //    int roll = dice.Next(1, 6);
        public static void Initilisation()
        {
            int position = 0;
            Random dice = new Random();
            int roll = dice.Next(1, 6);


            Console.WriteLine(" Starting at the position: {0}" ,position);
            Console.WriteLine("The random dice is :");
        }

        public static void Random()
        {
            int position = 0;
            Random rndm = new Random();
            int option = rndm.Next(1, 4);// for option
            int roll = rndm.Next(1, 6);//for dice
            while (position < 100)
            {
                if (option == 1)  //No Play
                {
                    Console.WriteLine($"Dice Rolled: {roll}, Option is: No Play, Position: {position}");
                }
                else if (option == 2)  //ladder-player moves ahead by the no. of positon received in the die
                {
                    position = position + roll;
                    if (position > 100) position = 100;
                    Console.WriteLine($"Dice Rolled: {roll}, Option is: Ladder, Position: {position}");

                }
                else if (option == 3) // snake - player moves behind by the no. of positon received in the die
                {
                    position = position - roll;
                    Console.WriteLine($"Dice Rolled: {roll}, Option is: Ladder, Position: {position}");

                }
                
            }

            if (position == 100)
            {
                Console.WriteLine("Congratulations. Player wins the game");
            }
            if(position < 0)
            {
                Console.WriteLine("Restart the game from 0");
            }

        }
    }
}
