using System;

namespace _29092020
{
    class soal2
    {
        public void bulanswitch()
        {
            Console.WriteLine("Masukkan nilai angka (1-12) : ");
            int angka = Convert.ToInt32(Console.ReadLine());

            switch(angka)
            {
                case 1:
                  Console.WriteLine("Januari");
                  break;
                case 2:
                  Console.WriteLine("Februari");
                  break;
                case 3:
                  Console.WriteLine("Maret");
                  break;
                case 4:
                  Console.WriteLine("April");
                  break;
                case 5:
                  Console.WriteLine("May");
                  break;
                case 6:
                  Console.WriteLine("Juni");
                  break;
                case 7:
                  Console.WriteLine("Juli");
                  break;
                case 8: 
                  Console.WriteLine("Agustus");
                  break;
                case 9:
                  Console.WriteLine("September");
                  break;
                case 10:
                  Console.WriteLine("Oktober");
                  break;
                case 11:
                  Console.WriteLine("November");
                  break;
                case 12:
                  Console.WriteLine("Desember");
                  break; 
                default:
                  Console.WriteLine("Harus input 1-12");
                  break;
            }
            bulanswitch();            
        }
    }
}    