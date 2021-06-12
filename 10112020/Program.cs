using System;

namespace _10112020
{
    class Program
    {
        static void Main(string[] args)
        {
            int []numbers = {12, 15, 20, 30, 50, 100, 200, 1000};

            foreach( int number in numbers )
            {
                Console.WriteLine( number );
            }
        }
    }
}
