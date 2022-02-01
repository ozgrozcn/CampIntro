using System;
using System.Collections.Generic;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[5] gibi bir kullanım dizi eleman sayısını belirlemek için kullanılır.
            //string[] isimler = new string[] {"Özgür","Engin","Kerem","Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];  // Yukarıdaki arrayden farklı bir adresi olduğu için tüm elemanları boş bir dizi oldu.
            //isimler[4] = "İlker"; // Bu kodda eklemiş gibi görebiliyoruz.
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]); // Fakat tekrar 0. indeksteki elemanı yazdığımızda bunu göremeyecek çünkü dizi boşaldı.

            List<string> isimler2 = new List<string> { "Özgür", "Engin", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
