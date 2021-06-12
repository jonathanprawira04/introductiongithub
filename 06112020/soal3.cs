using System;

namespace  _06112020
{
    class soal3
    {
        public void bilangan() //kita sedangn membuat function di Class 
        {
            Console.Write("Jumlah Bilangan Kuadrat : ");
            int jumlah = Convert.ToInt32(Console.ReadLine());

            for(int angka = 1; angka <= jumlah; angka++)
            {
                Console.Write(angka*angka +" ");
            }
        }
    }
}