using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Kayısı";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Malatya kayısısı";

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.Adi = "Karpuz";
            urun3.Fiyati = 20;
            urun3.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2,urun3  };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Id + " :" + urun.Adi + " " + urun.Fiyati + " " + urun.Aciklama);
            }

            Console.WriteLine("------Metotlar---------");

            //instance - class ürün örneği
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);


            sepetManager.Ekle2("elma" , "yeşil elme" ,5);
            sepetManager.Ekle2("karpuz", "db karpuzu", 5);







            Console.WriteLine("Hello World!");
        }
    }
}
