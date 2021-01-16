using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product urun)
        {

            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, String aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler. sepete eklendi :" + urunAdi);

        }
    }
}
