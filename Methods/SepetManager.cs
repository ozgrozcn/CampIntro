using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        // naming convention
        // syntax
        public void Ekle(Product urun) 
        { 
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        /*
         Yanlış kullanım. Ekstra parametre eklenirse tüm sayfalar hata verecektir.
         Metodun kullanıldığı tüm sayfalara gidip ekstra argüman tanımlaması yapmamız gerekir. 
         Yukarıdaki gibi bir kullanımda ise sadece ürün içerisine ilgili parametrenin property olarak verilmesi yeterli olur.
         */
        /* 
         Bu şekilde tanımlandığında düzensiz olacak bir yapıyı yukarıdaki metotta olduğu gibi düzenli olarak
        (tüm özellikleri parametre olarak verdiğimiz nesnede tutarak) oluşturduğumuzda encapsullation yapmış oluyoruz.
          */
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urunAdi);
        }
    }
}
