using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> 
    {
        T[] items; //T'nin tipi değişebilir
        public MyList()  //constructor => class'ı new'lediğimiz zaman otomatik çalışır
        {
            items = new T[0];
        }
        public void Add(T item) //kullanıcı veri tipi olarak ne verirse onu alır
        {
            T[] tempArray = items; //gecici dizinin items'in referansını tutuyor gecici olarak
            items = new T[items.Length+1]; //dizinin eleman sayısı 1 arttı
            //items=tempArray;
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //items emaneten verdiği elemanlarını geri alıyor
            }
            items[items.Length - 1] = item; //items'in son elemanına yeni elemanı ekledik
        }
        public int Length
        {
            get 
            {
                return items.Length;
            }
        }
        public T[] Items
        {
            get
            {
                return items;
            }
        }
    }
}
