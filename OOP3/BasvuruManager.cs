using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //                                     Method injection 
        public void BasvuruYap(IKrediManager krediManager , List<ILoggerService> loggerServices) // bütün kredilerin referansını tuttuğu için Ikeriyi kullandık.
        {
            //    KonutKrediManager konutKrediManager = new KonutKrediManager();
            //    konutKrediManager.Hesapla();
            //    bu şekilde yapılırsa tüm basvuruları konut kredisine bağımlı hale getiririz.
            // tek bir kredinin hesabı yapılır
            krediManager.Hesapla();
            
            
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
            // aynı veri türünde 1'den fazla verinin hesabını yapmak için list kullandık
            //listedeki her bir kredinin hesabını yapıyoruz.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }



    }
}
