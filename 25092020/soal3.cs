using System;

namespace _25092020
{
    class soal3
    {
        public void ulang()
        {
            Console.Write("Masukkan nilai sisi : ");
            int sisi = Convert.ToInt32(Console.ReadLine());

            int luas = sisi * sisi;

            Console.WriteLine("Luas Persegi adalah "+luas);

            ulang();
        }
    }
}