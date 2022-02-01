using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{ 
    // Operasyon tutan sınıflarda genelde Manager, Service gibi isimler kullanılır.
    class ProductManager
    {
        // CRUD - Create Read Update Delete   -> General Operations

        /*
         void: Değer dönmesine gerek olmayan, "git ve şunu yap" şeklinde kullanılabilen metot tipidir.
        
         int, float, double vs. : Değer dönebilen (return) metotlardır. Dönülen değere göre keyword seçilir.
        */
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

    }
}
