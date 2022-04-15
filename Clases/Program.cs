using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class çağırma
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Eğitmen = "Sema";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "C++";
            kurs2.Eğitmen = "Kadir";
            kurs2.IzlenmeOranı = 69;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Php";
            kurs3.Eğitmen = "Mehmet";
            kurs3.IzlenmeOranı = 80;

            //Console.WriteLine(kurs1.kursAdi + " " + kurs2.kursAdi + " " + kurs3.kursAdi);


            Kurs[] kurslar = new Kurs[]
            {
                kurs1,
                kurs2,
                kurs3
            };
            foreach(var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " " + kurs.Eğitmen);
            }


            Console.ReadLine();
        }

        class Kurs
        {
            public string kursAdi { get; set; }
            public string Eğitmen { get; set; }
            public int IzlenmeOranı { get; set; }
        }
    }
}
