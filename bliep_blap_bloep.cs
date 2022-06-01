using System;

namespace bliep_blap_bloep

{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            do
            {

                //bliep divide by 2 AND 7 
                if (i % 2 == 0 && i % 7 == 0) ;
                Console.WriteLine("bliep");
                //blap divide by only 2 
                Console.WriteLine("", i++);
                if (i % 2 == 0)
                    Console.WriteLine("blap", i);
                //blap divide by only 7 
                if (i % 7 == 0)
                    Console.WriteLine("bloep", i);
               // if not any just put the number 
               if (i % 2 != 0)
                    Console.WriteLine(i);


            } while (i <= 100);
           

            Console.ReadLine();
        }
    }
}