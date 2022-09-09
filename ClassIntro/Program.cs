using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin Demiroğ";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEğitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEğitmeni = "Kerem Varış";
            kurs2.IzlenmeOrani = 72;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEğitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C ++";
            kurs4.KursEğitmeni = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;


            //Console.WriteLine(kurs1.KursAdi  + " :" + kurs1.KursEğitmeni + ":" + kurs1.IzlenmeOrani  );

            Kurs[] kurslar = new Kurs[] {kurs1 , kurs2 , kurs3 , kurs4 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " :" + kurs.KursEğitmeni + ": " + kurs.IzlenmeOrani);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEğitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
        
    }


}
