using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // Generic class, çalışacağımız özel bir tip olacağını belirttiğimiz classlardır.
    // Bu tip öntanımlı ya da bizim oluşturduğumuz tip olabilir.
    class MyList<T> // Tek tip ile kullanacaksak kullanım olarak T yazılır. Ama istediğimizi yazabiliriz.
    {
        T[] items; // Doğrudan class içerisinde global namespacede olduğu için class içerisinde her blokta görülebilir.
        public MyList() // Constructor metot, obje oluşturulduğu anda çalışır. 
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // items'ın referansını geçici diziye atıyoruz.
            items = new T[items.Length+1];
            for (int idx = 0; idx < tempArray.Length; idx++)
            {
                items[idx] = tempArray[idx];
            }
            items[items.Length - 1] = item;
        }
    }
}
