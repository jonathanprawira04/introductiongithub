using System;

namespace _25092020
{
    public class soal2
    {
        public void ketuntansan()
        {
            Console.Write("Masukkan nilai : ");
            Double Nilai = Convert.ToDouble(Console.ReadLine());

            if(Nilai>75)
            {
                Console.WriteLine("lulus");
            }
            else
            {
                Console.WriteLine("Tidak lulus");
            }
        }
    }
}