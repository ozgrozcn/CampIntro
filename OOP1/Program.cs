using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; 
            /* Bu numara veritabanında bir kategoriyle eşleşiyor. 
               Bunu yapma amacı kategorinin değişebilecek olması.
               Değişim durumunda kodu değil de veritabanında 2'nin karşılığı değiştiririz.
             */
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // Bu şekilde nesne oluştururken propertieslerini vererek de oluşturabiliriz. Initiliazer gibi.
            Product product2 = new Product {Id=2, CategoryId=5, UnitsInStock=5, 
                ProductName="Kalem", UnitPrice=35};

            // PascalCase - camelCase
            ProductManager productManager = new ProductManager();
            
        }
    }
}
