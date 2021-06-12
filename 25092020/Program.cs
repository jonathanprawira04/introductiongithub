using System;

namespace _25092020
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to 25Sept2020's Projects");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("1. Contoh Sekuensial");
            Console.WriteLine("2. Contoh Seleksi");
            Console.WriteLine("3. Contoh Repetisi");
            Console.WriteLine("4. Contoh outpun dan");
            Console.WriteLine("5. Contoh output atau");
            Console.Write("Piliih menu (1-5) : ");
            int menu = Convert.ToInt32(Console.ReadLine());

            if( menu == 1 )
            {
                soal1 s1 = new soal1();
                s1.volume_balok();
            }
            else if( menu == 2 )
            {
                soal2 s2 = new soal2();
                s2.ketuntansan();
            }
            else if( menu == 3 )
            {
                soal3 s3 = new soal3();
                s3.ulang();
            }
            else if( menu == 4 )
            {
                soal4 s4 = new soal4();
                s4.dan();
            }
            else if( menu == 5 )
            {
                soal5 s5 = new soal5();
                s5.atau();
            }
            else
            {
                Console.WriteLine("Tidak ada dalam pilihan");
            }
            Console.WriteLine("Apakah ingin mengulang program ini ? ");
            char ulang = Convert.ToChar(Console.ReadLine());

            if( ulang =='y')
            {
                Console.Clear();
                Main();
            }
        }
    }
}
