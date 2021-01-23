using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi 
            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlama başlangıç için temel kurs",
                "Java",
                "Phyton",
                "C++",
                "C#"
            };
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti...");
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}