using System;

namespace _29092020
{
    class soal3
    {
        public void hari()
        {
            Console.WriteLine("Masukkan angka (1-7) : ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if( angka == 1 )
            {
                Console.WriteLine("Senin");
            }
            else if( angka == 2 )
            {
                Console.WriteLine("Selasa");
            }
            else if( angka == 3 )
            {
                Console.WriteLine("Rabu");
            }
            else if( angka == 4 )
            {
                Console.WriteLine("Kamis");
            }
            else if( angka == 5 )
            {
                Console.WriteLine("Jumat");
            }
            else if( angka == 6 )
            {
                Console.WriteLine("Sabtu");
            }
            else if( angka == 7 )
            {
                Console.WriteLine("Minggu");
            }
            else 
            {
                Console.WriteLine("Masukkan angka 1-7");
            }
            hari();
        }
    }
}        