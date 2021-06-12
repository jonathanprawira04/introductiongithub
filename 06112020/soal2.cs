using System;

namespace  _06112020
{
    class soal2
    {
        public void bilanganKelipatanLima() //kita sedangn membuat function di Class 
        {
            int bilangan = 5;

            Console.Write("Jumlah Bilangan Kelipatan Lima : ");
            int jumlah = Convert.ToInt32(Console.ReadLine());

            for(int angka = 1; angka <= jumlah; angka++)
            {
                Console.Write(bilangan+" ");

                bilangan +=5;
            }
        }
    }
}