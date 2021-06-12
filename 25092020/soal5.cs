using System;

namespace _25092020
{
    class soal5
    {
        public void atau()
        { 
            Console.WriteLine("Program menghitung keliling atau luas Persegi Panjang");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Masukkan nilai p : ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai l : ");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hitung keliling (k) atau luas (l) ? (k/l) ");
            char opsi = Convert.ToChar(Console.ReadLine());

            if(opsi =='k')
            {
                int k = 2 * (p+l);
                Console.WriteLine("Keliling Persegi Panjang adalah "+k);
            }else if(opsi == 'l')
            {
                int L = p * l;
                Console.WriteLine("Luas Persegi Panjang adalah "+L);
            }
            else
            {
                Console.WriteLine("Tidak ada dalam opsi!");
            }
        }
    }
}