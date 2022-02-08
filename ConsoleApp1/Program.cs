using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Courses course1 = new Courses();
            Courses course2 = new Courses();
            Courses course3 = new Courses();
            course1.CourseName = "C#";
            course1.CourseTeacher = "Engin Demiroğ";
            course1.IzlenmeOranı = 68;
            course2.CourseName = "Java";
            course2.CourseTeacher = "Engin Demiroğ";
            course2.IzlenmeOranı = 70;
            course3.CourseName = "React";
            course3.CourseTeacher = "Engin Demiroğ";
            course3.IzlenmeOranı = 80;
            //Console.WriteLine(course1.CourseName + " " + course1.CourseTeacher + " " + course1.IzlenmeOranı);
            Courses[] courses = new Courses[] { course1, course2, course3 };
            foreach (var item in courses)
            {
                Console.WriteLine(item.CourseName + ": " + item.CourseTeacher + " " + item.IzlenmeOranı);
            }
            Basketball b1 = new Basketball(){name="Ufuk",age=21,size=1.90 };
            Basketball b2 = new Basketball(){name="Cristiano",age=22,size=1.70 };
            Basketball b3 = new Basketball(){name="Ümit",age=23,size=1.87};
          
            Basketball[] players = new Basketball[] {b1,b2,b3};
            string grup;
            foreach (var item in players)
            {
                if(item.size > 1.85)
                {
                    grup = "UZUN";
                }
                else
                {
                    grup = "KISA";
                }
                Console.WriteLine("Ad: "+item.name+" Yaş: "+item.age+" Boy: "+item.size+" Grubu: "+grup);
            }
            Menu m1 = new Menu() { fiyat = 20, icecekler = "Kola", yemekAdi = "Karnabahar" };
            Menu m2 = new Menu() { fiyat = 30, icecekler = "Ayran", yemekAdi = "Brokoli" };
            Menu m3 = new Menu() { fiyat = 40, icecekler = "Soğuk Çay", yemekAdi = "Tavuk" };
            Menu[] menu = new Menu[] { m1, m2, m3 };
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine("Fiyatı: "+menu[i].fiyat+" İçecekler: "+menu[i].icecekler+" Yemek adi: "+menu[i].yemekAdi);
            }


        }
        class Menu
        {
            public string yemekAdi { get; set; }
            public string icecekler { get; set; }
            public int fiyat { get; set; }
        }
        class Basketball{
            public string name { get; set; }
            public int age { get; set; }
            public double size { get; set; }
        }
        class Courses
        {
            public string CourseName { get; set; }
            public string CourseTeacher { get; set; }
            public int IzlenmeOranı { get; set; }
        }
    }
}
