using System;

namespace _13102020
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("PROGRAM IMPLEMENTASI STRUKTUR ALGORITMA REPETISI");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("1. Cetak baris angka : 2 5 4 10 6 15 (pakai for)");
            Console.WriteLine("2. Cetak bilangan ganjil (pakai while, bilangan antara 1 - 100)");
            Console.WriteLine("3. Buat contoh kasus bilangan menggunakan do while");
            Console.WriteLine("4. Cetak bilangan fibonacci (silahkan cari referensi di internet) (for)");
            Console.Write("Piliih menu (1-4) : ");
            int menu = Convert.ToInt32(Console.ReadLine());

            if( menu == 1 )
            {//baris angka 2 5 4 10 6 15
                Console.Write("Hasilnya adalah : ");
                int a = 2;
                for(int b=5; b<=15; b+=5)
                {
                    Console.Write(a + " " + b + " ");
                    a+=2;
                }
            }
            else if( menu == 2 )
            {//bilangan ganjil
                Console.Write("Hasilnya adalah : ");
                int a = 1;
                while( a <=100 )
                {
                    Console.Write (a + " ");
                    a +=2;
                }
            }
            else if( menu == 3 )
            {//contoh kasus menggunakan do while
                int a = 5;
                do
                {
                    Console.WriteLine("Coding");
                    a--;
                }
                while(a>=1);
            }
            else if( menu == 4 )
            {//cetak bilangan fibonacci
                int x = 1, y = 1, z = 1;             
                Console.Write("Masukan jumlah bilangan fibonacci = ");             
                int jumlah = Convert.ToInt32(Console.ReadLine());             
                for (int i = 0; i < jumlah; i++)             
                {                 
                    Console.Write(z + " ");                 
                    z = x + y;                 
                    x = y;                 
                    y = z;             
                }             
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
