using System;

namespace ConsoleApplication2
{
    class latihan20
    {
        static void Main() 
        {
            Console.Write("Bilangan batas bilangan fibonaci : ");
            int abc = Convert.ToInt32(Console.ReadLine());
            int e = 1;
            for(int d = 0; d<+abc; d+=e)
            {
                e+=d;
                if(e<+abc)
                {
                    Console.Write(d + " " + e + " ");
                }
            }
        }
    }
}
