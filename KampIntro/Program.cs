using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true; // veri kaynağından gelir. Database gibi

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Settings Button");
            }
            else
            {
                Console.WriteLine("SignIn Buttons");
            }
            
            
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
