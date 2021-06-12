using System;

namespace _25092020
{
    class soal4
    {
        public void dan()
        { //input
            Console.WriteLine("Program menghitung keliling dan luas Persegi Panjang");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Masukkan nilai p : ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai l : ");
            int l = Convert.ToInt32(Console.ReadLine());

            //proses
            int k = 2 * (p+l);
            int L = p * l ;

            //output
            Console.WriteLine("Nilai keliling adalah "+k+" dan luasnya adalah "+L);
        }
    }
}