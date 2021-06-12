using System;

namespace _25092020
{
    class soal1
    {
        public void volume_balok()
        {
            //input
            Console.Write("Program Menghitung Volume Balok\n");
            Console.Write("-------------------------------\n");

            int panjang, lebar, tinggi; 
            Console.WriteLine("Masukkan nilai panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            //proses
            int volume = panjang * lebar * tinggi;
             
            //output 
            Console.WriteLine("Nilai volume balok adalah "+volume);
        }
    }
}