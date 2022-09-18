using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //CoorporateCustomer
    class TuzelMusteri : Musteri //operasyon classına hem tüzel hem de gerçek kişi göndermek için inheritance yapıldı

        
    {
        
        public string SirketAdi { get; set; }
        // veri üzerinde sayısal işlem yapılmıyorsa stringde tutulması daha iyidir. 
        public string VergiNo { get; set; }
        // bir nesnede bir değeri kullanmak zorunda değilsek orada soyutlama hatası yapılıyordur.
    }
}
