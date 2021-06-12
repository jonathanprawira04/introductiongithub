using System;

namespace _29092020
{
    class soal1
    {
        public void bulanif()
        {
            Console.WriteLine("masukkan nilai angka (1-12) : ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if( angka == 1 )
            {
                Console.WriteLine("Januari");
            }
            else if( angka == 2 )
            {
                Console.WriteLine("Februari");
            }
            else if( angka == 3 )
            {
                Console.WriteLine("Maret");
            }
            else if( angka == 4 )
            {
                Console.WriteLine("April");
            }
            else if( angka == 5 )
            {
                Console.WriteLine("May");
            }
            else if( angka == 6 )
            {
                Console.WriteLine("Juni");
            }
            else if( angka == 7 )
            {
                Console.WriteLine("Juli");
            }
            else if( angka == 8 )
            {
                Console.WriteLine("Agustus");
            }
            else if( angka == 9 )
            {
                Console.WriteLine("September");
            }
            else if( angka == 10 )
            {
                Console.WriteLine("Oktober");
            }
            else if( angka == 11 )
            {
                Console.WriteLine("November");
            }
            else if( angka == 12 )
            {
                Console.WriteLine("Desember");
            }
            else
            {
                Console.WriteLine("Harus angka 1-12");
            }
            bulanif();
        }
    }
}