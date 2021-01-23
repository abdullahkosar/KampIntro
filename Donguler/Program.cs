using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kursu";
            string kurs3 = "Java";
            string kurs4 = "Phyton";

            
            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" , "Programlamaya Başlangıç İçin Temel Kursu" , "Java", "Phyton","C++","C++"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            //dizi temelli yapıları tek tek dönmek için kullanılır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            

            Console.WriteLine("Sayfa Sonu - footer");




            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }            
        }
    }
}
