using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBoyutluDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] regions = new string[5, 3]//Satırlar sıfırıncı, sütunlar birinci 
            {
                {"İstanbul", "İzmit", "Balıkesir" },
                {"Ankara", "Konya", "Kırıkkale" },
                {"Antalya", "Adana", "Mersin" },
                {"Rize", "Trabzon", "Samsun" },
                {"İzmir", "Muğla", "Manisa" }
            };


            //GetUpperBound=En üst değeri yakala
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("------------");
            }

            Console.ReadLine();
        }
    }
}
