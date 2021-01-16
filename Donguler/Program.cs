using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlama başlangıç için temel kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı",
                    "Programlama başlangıç için temel kurs",
                    "Java",
                    "Python",
                    "c#"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach ( string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("SAYFA SONU - FOOTER");
            
        }

    }
}
