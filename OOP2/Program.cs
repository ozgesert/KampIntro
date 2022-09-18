using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.MusteriAdi = "Engin";
            musteri1.MusteriSoyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54123";
            musteri2.SirketAdi = "Kodlama i.o";
            musteri2.VergiNo = "1234567890";

            // musteri  base classı hem tuzel in hem de gercek must.nın referansını tutuyor
            Musteri musteri3 = new GercekMusteri(); 
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);


            
    

        }
    }
}
