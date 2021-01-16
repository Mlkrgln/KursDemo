using System;

namespace KursDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself -kendini tekrarlama
            // değer tutucu ,alias

            string kategoriEtiketi = "kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 1.75;
            double dolarBugun = 1.85;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış ");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış");
            }

            else
            {
                Console.WriteLine("değişmedi");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
