using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici kampı";
            string kurs2 = "java";
            string kurs3 = "programlama yeni baslayanlar için temel kurs";

            string[] kurslar = new string[] { "yazılım geliştirici kampı" , "java" , "programlama yeni baslayanlar için temel kurs" };

            for (int i = 0; i< kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        } 
        
    }
}
