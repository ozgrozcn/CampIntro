using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety : tip güvenliği
            // DO NOT REPEAT YOURSELF
            string kategoriEtiketi = "Kategoriler"; // değer tutucu, alias
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true; // logical variable

            double dolarDun = 7.55,dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku Göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku Göster");
            }
            else
            {
                Console.WriteLine("Değişmedi Sembolü Göster");
            }


            if (sistemeGirisYapmisMi == true) // Çift Tab code snippetsi getirir.
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);        
        }
    }
}
