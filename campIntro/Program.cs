using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[]
            {
                "Sema",
                "Alıcı"
            };
            foreach (var name in isimler) 
            {
                //Console.WriteLine(name);   
            }

            List<string> list = new List<string>()
            {
                
            };

            list.Add("Gamze");
            Console.WriteLine(list.Count);

            foreach (var name in list)
            {
                Console.WriteLine(name);
            }


            Console.ReadLine();
        }
    }
}
