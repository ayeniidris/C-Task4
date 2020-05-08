using System;

namespace WebApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
           int sqr1 =Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(Math.Sqrt(sqr1).ToString());

            Console.WriteLine("Enter a number: ");
            int sqr2 =Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(Math.Sqrt(sqr2).ToString());

            if (sqr1 > sqr2)
            {
                Console.WriteLine("The number " + sqr1 + " has a higher square root than the number " + sqr2);
            }

            else if (sqr1 < sqr2)
            {
                Console.WriteLine("The number" + sqr2 + "has a higher square root than the number" + sqr1);
            }

            else if(sqr1 == sqr2)
            {
            Console.WriteLine("Enter another value");
            }

            else if (sqr1 < 0 && sqr2 < 0)
            {
            Console.WriteLine("Error");
            }
        }
    }
}
