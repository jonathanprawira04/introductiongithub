using System;

namespace _29092020
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to 29Sept2020's Projects");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("1. Input 1-12 munculkan nama bulan Januari-Desember (pakai if)");
            Console.WriteLine("2. Input 1-12 munculkan nama bulan Januari-Desember (pakai switch)");
            Console.WriteLine("3. Input 1-7 munculkan nama hari Senin-Minggu (pakai if)");
            Console.WriteLine("4. Buat contoh penggunaan shorthand if (kasus apa saja)");
            Console.WriteLine("5. Input Payung");
            Console.Write("Piliih menu (1-5) : ");
            int menu = Convert.ToInt32(Console.ReadLine());

            if( menu == 1 )
            {
                soal1 s1 = new soal1();
                s1.bulanif();
            }
            else if( menu == 2 )
            {
                soal2 s2 = new soal2();
                s2.bulanswitch();
            }
            else if( menu == 3 )
            {
                soal3 s3 = new soal3();
                s3.hari();
            }
            else if( menu == 4 )
            {
                soal4 s4 = new soal4();
                s4.baterai();
            }
            else if( menu == 5 )
            {
                soal5 s5 = new soal5();
                s5.payung();
            }
            else
            {
                Console.WriteLine("Tidak ada dalam pilihan");
            }
            Console.WriteLine("Apakah ingin mengulang soal ini ? ");
            char ulang = Convert.ToChar(Console.ReadLine());

            if( ulang =='y')
            {
                Console.Clear();
                Main();
            }
        }
    }
}