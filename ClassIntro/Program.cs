using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs Kurs1 =new Kurs();
            Kurs1.KursAdi = "C#";
            Kurs1.Egitmen = "MELİKE KARAOĞLAN";
            Kurs1.İzlenmeOrani = 78;

            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "JAVA";
            Kurs2.Egitmen = "BERKAY";
            Kurs2.İzlenmeOrani = 78;

            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "PİTON";
            Kurs3.Egitmen = "SESİL";
            Kurs3.İzlenmeOrani = 78;

            // Console.WriteLine(Kurs1.KursAdi + " " + Kurs1.Egitmen) ;

            Kurs[] kurslar = new Kurs[]
            {
                Kurs1,Kurs2,Kurs3
            };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.Egitmen);
            }

        }


        class Kurs
        {
            public string KursAdi { get; set; }

            public string Egitmen { get; set; }

            public int İzlenmeOrani { get; set; }
        }
    }
}
