using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();      
            IKrediManager tasitKrediManager = new TasitKrediManager();        
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();


            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new DatabaseLoggerService(), new FileLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager , new DatabaseLoggerService());
            //basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
            //basvuruManager.BasvuruYap(tasitKrediManager, new DatabaseLoggerService());
            //basvuruManager.BasvuruYap(esnafKrediManager , new FileLoggerService());
            //basvuruManager.BasvuruYap(esnafKrediManager, new List<ILoggerService> {new DatabaseLoggerService() , new SmsLoggerService() }); //polimorfizm
            basvuruManager.BasvuruYap(esnafKrediManager, loggers); 



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, konutKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
           
            //SOLID in O harfi: sisteme yeni bir kullanıcı eklendiğinde mevcut kodlar etkilenmez
                 


        }
    }
}
