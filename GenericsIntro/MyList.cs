using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items= new T[0];  //Liste eleman eklenmeden önce 0 elemanlıdır diye tanımladık
        }
        public void Add (T item)  //Git ekle
        {
            T[] tempArray = items; //önceki verileri tut
            items=new T[items.Length+1];  //başladığında 0 elemanlıydın artık 1 elemanlı ol
            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i]=tempArray[i]; //items eski verilerine kavuştu
            }
            items[items.Length -1] = item; //index numarası 0'dan başladığı için 
        }

        public int Lenght
        {
            get { return items.Length; }    
        }
        public T[] Items
        {
            get { return items; }
        }

    }
}
