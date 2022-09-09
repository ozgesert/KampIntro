using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    // operasyon tutucu alan
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string adi , string aciklama , int fiyat)
        {
            Console.WriteLine("Sepete eklendi");
        }



        public void Kaldır(Urun urun)
        {
            Console.WriteLine("Sepetten çıkarıldı : " + urun.Adi);
        }
    }
}
