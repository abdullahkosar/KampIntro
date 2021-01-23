﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            //class içerisinde bilgi tanımlarken diziyi new'lemek gerekli
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler   = new Urun[] { urun1, urun2 };

            //in urunler: urunler dizisinin içini geziyor
            //in önündeki takma isimdir
            //Urun tip güvenliğidir type safety Urun biz class yaptığımız için kullanabiliyoruz var 'da olabilir
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("...................");


            }

            Console.WriteLine("-----------Metotlar-------------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 14,8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 60,6);




            Console.WriteLine("Hello World!");
        }
    }
}


//Metotlar bir programı tekrar tekrar yazmamak için kullanılır.
//Sayfaları tek tek değiştirmek yerine aynı olan kodları Metotlar ile yazarız.
//DRY - Do not Repeat Yourself
