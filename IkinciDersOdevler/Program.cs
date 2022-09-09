using System;

namespace IkinciDersOdevler
{
    class Program
    {
        static void Main(string[] args)
        {
            Product  product1 = new Product();
            product1.ProductCampaign = "Nivea";
            product1.ProductName = "yüz temizleme jeli";
            product1.PriceOfProduct = 159;
            product1.CurrencyUnit = "TL";

            Product product2 = new Product();
            product2.ProductCampaign = "Rokkie";
            product2.ProductName = "scooter";
            product2.PriceOfProduct = 299;
            product2.CurrencyUnit = "TL";

            Product product3 = new Product();
            product3.ProductCampaign = "Hummel";
            product3.ProductName = "Porter çocuk ayakkabı";
            product3.PriceOfProduct = 192;
            product3.CurrencyUnit = "TL";

            Product[] products = new Product[] {product1, product2, product3};
            foreach ( Product product in products)
            {
                Console.WriteLine(product.ProductCampaign + ":" + product.ProductName + ":"+ product.PriceOfProduct + " "+ product.CurrencyUnit);
            }

            Console.WriteLine("///foreach sonu --- for baslangic///");

            for (int i = 0; i < products.Length  ; i++)
            {
                Console.WriteLine( products[i].ProductCampaign + " : "+ products[i].ProductName +" " +products[i].PriceOfProduct + " " + products[i].CurrencyUnit);
            }

            Console.WriteLine("///for sonu --- while baslangic///");

            int p = 0;
            while (p<products.Length)
            {
                Console.WriteLine(products[p].ProductCampaign + " : " + products[p].ProductName + " " + products[p].PriceOfProduct + " " + products[p].CurrencyUnit);
                p++;
            }
        }
    }



    class Product
    {
        
        public string ProductName { get; set; }
        public string ProductCampaign { get; set; }
        public int PriceOfProduct { get; set; }
        public string CurrencyUnit { get; set; }


    }
}
