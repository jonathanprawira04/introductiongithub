using System;

namespace _29092020
{
    class soal4
    {
        public void baterai()
        {
            Console.WriteLine("Masukkan kondisi 100 atau 0 : ");
            int angka = Convert.ToInt32(Console.ReadLine());

            string kondisi = ( angka == 100 ) ? "baterai penuh" : "baterai habis";

            Console.WriteLine("Kondisi sekarang adalah "+kondisi);

            baterai();
        }
    }
}        