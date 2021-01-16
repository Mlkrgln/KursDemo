using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();

            urun1.Adi = "elma";
            urun1.Fiyati = 16;
            urun1.Aciklama = "Amasya elma";
            urun1.StokAdedi = 100;

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Adana Karpuzu";
            urun2.StokAdedi = 200;

            Product[] urunler = new Product[] {urun1,urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);

            }

            Console.WriteLine("--------------Metotlar------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut","Yeşil" ,12,10);
            sepetManager.Ekle2("A2", "Y2", 115,100);



        }

    }
}
