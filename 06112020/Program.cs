using System;

namespace _06112020
{
    class Program
    {
        static void Main()
        {
            int menu;

            Console.WriteLine("Program Bilangan");
            Console.WriteLine("----------------");
            Console.WriteLine("1. Bilangan Genap");
            Console.WriteLine("2. Bilagan : 5 10 15 20 25 ...");
            Console.WriteLine("3. Bilangan : 1 4 9 16 25 36 ...");
            Console.Write("Menu : ");
            menu = Convert.ToInt32(Console.ReadLine());

            if( menu == 1 )
            {
                soal1 s1 = new soal1();
                s1.bilanganGenap();
            }
            else if( menu == 2 )
            {
                soal2 s2 = new soal2();
                s2.bilanganKelipatanLima();
            }
            else if( menu == 3 )
            {
                soal3 s3  = new soal3();
                s3.bilangan();
            }

            Console.Write("Apakah anda ingin mengulang (y/n) ? ");
            char pilihan = Convert.ToChar(Console.ReadLine());

            if( pilihan == 'y' )
            {
                Main();
            } 
        }
    }
}
