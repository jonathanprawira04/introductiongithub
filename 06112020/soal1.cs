using System;

namespace  _06112020
{
    class soal1
    {
        public void bilanganGenap() //kita sedangn membuat function di Class 
        {
            int bilangan = 2;

            Console.Write("Jumlah Bilangan Genap : ");
            int jumlah = Convert.ToInt32(Console.ReadLine());

            for(int angka = 1; angka <= jumlah; angka++)
            {
                Console.Write(bilangan+" ");

                bilangan +=2;
            }
        }
    }
}