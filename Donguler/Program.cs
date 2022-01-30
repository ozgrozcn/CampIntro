using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Giriş Kursu";
            string kurs3 = "Java";
           
            // array - dizi 
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı","Programlamaya Giriş Kursu", "Java","Python","C++"};

            for (int i = 0; i < kurslar.Length ; i++) // .Length -> Dizinin eleman sayısını verir.
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("------For bitti-------");
            // Dizileri kolay dolaşmak için genellikler foreach kullanılır.
            foreach (string kurs in kurslar) // kurs -> alias Python'daki gibi. 
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
