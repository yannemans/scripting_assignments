using System;

namespace nice_if_you_like_dice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            // creates a number between 1 and 6 for dice 1
            int dice1 = rnd.Next(1, 6);
            // creates a number between 1 and 6 from dice 2
            int dice2 = rnd.Next(1, 6);
            // creates a number between 1 and 12 from dice 3
            int dice3 = rnd.Next(1, 12);

            Console.WriteLine("press enter to start");
            Console.ReadLine();
            Console.WriteLine(dice1);
            Console.WriteLine(dice2);
            Console.WriteLine(dice3);

            // dice 3 is higher 
            if (dice1 +  dice2 < dice3)
            {
                Console.WriteLine("dice1 and 2 is lower then Dice6 + 6 ");

            }
            //dice 1 and 2 is higer 
            if (dice1 + dice2 > dice3)
            {
                Console.WriteLine("dice1 and 2 is higher then dice6 + 6");

            }
          
            Console.ReadLine();
        }
    }
}
