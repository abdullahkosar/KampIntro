using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 54566;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "54687651521";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 554546;
            musteri2.MusteriNo = "21545";
            musteri2.SirketAdi = "Kodlama.IO";
            musteri2.VergiNo = "5487121564";
            
            //Burada Musteri hem GercekMusteri hemde TuzelMusteri referanslarını tutabiliyor.
            Musteri musteri3 = new GercekMusteri();// new görüldüğünde referanstır.
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
