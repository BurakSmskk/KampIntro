using System;
using System.Security.Cryptography;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 86;

            
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 76;

            Urun[] urunler = new Urun[] {urun1,urun2};

            //type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------");
            }
            
            Console.WriteLine("--------------------------------------------METOTLAR---------------------");
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            
            
            //Encapsulation uymuyor.
            //sepetManager.Ekle2("Armut","Yeşil Armut",12,10);
            //sepetManager.Ekle2("Elma", "Yeşil Elma", 15,9);
            //sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 85,8);

        }
    }
}


// Do not repeat your self - DRY - Clean Code - Best Practice 