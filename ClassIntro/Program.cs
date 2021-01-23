using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Burak";
            int yas = 24;

            Course kurs1 = new Course();
            kurs1.CourseName = "C#";
            kurs1.Instructor = "Engin DEMIROG";
            kurs1.ViewRate = 68;

            Course kurs2 = new Course();
            kurs2.CourseName = "Java";
            kurs2.Instructor = "Kerem VARIS";
            kurs2.ViewRate = 64;

            Course kurs3 = new Course();
            kurs3.CourseName = "Phyton";
            kurs3.Instructor = "Berkay BILGIN";
            kurs3.ViewRate = 80;

            Course kurs4 = new Course();
            kurs4.CourseName = "C++";
            kurs4.Instructor = "Murat KURTBOGAN";
            kurs4.ViewRate = 100;

            // Console.WriteLine(kurs1.CourseName + " " + kurs1.Instructor + " " + kurs1.ViewRate);

            Course[] kurslar = new Course[]
            {
                kurs1,kurs2,kurs3,kurs4
            };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.CourseName + " : " + kurs.Instructor);
            }
        }


        class Course
        {
            public string CourseName { get; set; }
            public string Instructor { get; set; }
            public int ViewRate { get; set; }
        }



    }
}
