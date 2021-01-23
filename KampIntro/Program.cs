using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenliği bulunur
            //Do not repeat yourself - Kendini tekrarlama
            //değer tutucu, alias

            //metinsel ifadeler için değişken tanıtımıdır
            string kategoriEtiketi = "Kategoriler";

            int ogrensiSayisi = 32000;            
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }


            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);  

        }
    }
}
