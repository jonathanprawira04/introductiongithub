using System;

namespace _29092020
{
    class soal5
    {
        public void payung()
        {
            Console.WriteLine("ada bawa Payung (y/n) :  ");
            char payung = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("ada bawa Jas Hujan (y/n) : ");
            char jas_hujan = Convert.ToChar(Console.ReadLine());

            if( payung == 'y' && jas_hujan == 'y' )
            {
                Console.WriteLine( "Anda selamat dari basahnya hujan" );
            }
            else if( payung == 'y' && jas_hujan == 'n' )
            {
                Console.WriteLine( "Sebaiknya anda jalan kaki" );
            }
            else if( payung == 'n' && jas_hujan == 'y' )
            {
                Console.WriteLine( "Anda bisa naik motor" );
            }
            else if( payung == 'n' && jas_hujan == 'n' )
            {
                Console.WriteLine( "Lebih baik dirumah saja" );
            }
        }
    }
}