using System;

namespace geus_again
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int guess = 0, number;
            //Create an object of the Random class
            Random rnd = new Random();
            number = rnd.Next(1, 100);
            for (int i = 0; i < 100; i++)
            {
                Console.Write("Enter Guess :");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine("lower, try again");
                }
                else if (guess < number)
                {
                    Console.WriteLine("higher,  try again");
                }
                else
                {
                    Console.WriteLine("You Won !!\t {0} is the correct number", guess);
                    i = 100;
                }
                if (guess > 100)
                {
                    Console.WriteLine("this is too high choose a number between 1-100");

                }

                if (guess < 1)
                {
                    Console.WriteLine("this is too low choose a number between 1-100");


                }

            }
        }
    }
}