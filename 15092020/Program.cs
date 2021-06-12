using System;

namespace _25092020
{
    class Program
    {
        static void Main()
        {
            Console.Write("Masukkan nilai siswa : ");
            int nilai_siswa = Convert.ToInt32(Console.ReadLine());

            if ( nilai_siswa >= 90 )
            {
                Console.WriteLine("Nilai Anda : A");
            }else if( nilai_siswa >= 80 ){
                Console.WriteLine("Nilai Anda : B");
            }else if( nilai_siswa >= 70 ){
                Console.WriteLine("Nilai Anda : C");
            }else if( nilai_siswa < 70 ){
                Console.WriteLine("Nilai Anda : D");
            }
             
             Main();

            }
        }
    }

