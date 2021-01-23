using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int , double, float, bool bunlar değer tiplerdir
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            //array - diziler referans tiplerdir 
            

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            //bu aşamada sayilar2 dizisinin 0. elemanı 999 yapılıyor ve bu sayilar1 dizisine aktarılıyor referansı sayilar2 çünkü
            sayilar2[0] = 999;
            
            Console.WriteLine(sayilar1[0]);

               

            Console.WriteLine(sayi1);
        }
    }
}
