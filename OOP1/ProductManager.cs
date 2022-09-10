using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        // void : emir kipi gibi bir şey
        public void Add(Product product, Product product2)
        {
            Console.WriteLine("eklendi : " +product.ProductName+   " eklendi :"+  product2.ProductName);

        }

        public void Update(Product product, Product product2)
        {
            Console.WriteLine("eklendi : " + product.ProductName + " eklendi :" + product2.ProductName);

        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
           
        }
    }
}
