﻿using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5]; //burada artık isimler dizini 5 elemanlı fakat içerisi boş bir dizi hale getiriyoruz. Eski diziyle ilgisi kalmıyor.
            isimler[4]="ilker"; 
            Console.WriteLine(isimler[4]);  //diğerleri gelmiyor sadece ilker var artık
            Console.WriteLine(isimler[0]);

            Console.WriteLine("Burada hepsi bitti");
            Console.WriteLine("Burada hepsi bitti");
            Console.WriteLine("Burada hepsi bitti");
            Console.WriteLine("Burada hepsi bitti");
            Console.WriteLine("Burada hepsi bitti");


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);  



            Console.WriteLine("Hello World!");
        }
    }
}
