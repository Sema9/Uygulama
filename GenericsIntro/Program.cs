using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            MyList<string> list2 = new MyList<string>();
            list2.Add("Gamze");
            list2.Add("Sema");
            Console.WriteLine(list2.Lenght);
            foreach (var item in list2.Items)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadLine(); 
        }


    }
}
