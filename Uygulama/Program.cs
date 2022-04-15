using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Add();
            Delete();
            Update();

            Add2(2, 8);

            var result1=Add3(5);
            Console.WriteLine(result1);

            Console.WriteLine(Add4(2,4,9,12));

            Console.ReadLine();
        }


        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static void Delete()
        {
            Console.WriteLine("Deleted!");
        }

        static void Update()
        {
            Console.WriteLine("Update!");
        }


        static void Add2(int number1, int number2)
        {
            var result = number1 + number2;
            Console.WriteLine(result);
        }


        static int Add3(int number1, int number2=30)
        {
            var result1 = number1 + number2;
            return result1;
        }




        //params=değişken sayıda parametre almasına imkan veren bir anahtar kelimedir.
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
