using System;

namespace nicer_if_you_like_dicer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            // creates a number between 1 and 6 for dice 1
            int dice1 = rnd.Next(1, 6);
            // creates a number between 1 and 6 for dice 2
            int dice2 = rnd.Next(1, 6);
            // creates a number between 1 and 12 for dice 3
            int dice3 = rnd.Next(1, 12);
            // creats a number between 1 and 12 for dice 4
            int dice4 = rnd.Next(1, 12);

           
            Console.WriteLine("press enter to start");
            Console.ReadLine();
            Console.WriteLine("player one");
            Console.WriteLine(dice1 * dice2);
            Console.WriteLine("player 2");
            Console.WriteLine(dice3 + dice4);


            //player one wins if his number is higher 
            if (dice1 + dice2 > dice3 * dice4)
            {
                Console.WriteLine("dice1 and dice2  is higher then dice3 and dice4");
                Console.WriteLine("player 1 won ");
            }
            // player 2 wins if his number is higher
            if (dice1 + dice2 < dice3 * dice4)
            {
                Console.WriteLine("dice1 and dic2 is lower then dice3 and dice4");
                Console.WriteLine("player 2 won ");
            }

            Console.ReadLine();
        }
    }
}
