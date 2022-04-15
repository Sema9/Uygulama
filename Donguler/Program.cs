using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string kurs1 = "Yazılım Geliştirici Kursu";
            string kurs2 = "C++";
            string kurs3 = "C#";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            */

            string[] kurslar = new string[]
            {
                "PHP",
                "jAVA",
                "GO"
            };

            /*
            for(int i=0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            */

            foreach(string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.ReadLine();
        }
    }
}
