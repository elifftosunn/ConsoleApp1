
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] keys;
        T2[] values;
        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }
        public void Add(T1 x,T2 y)
        {
            T1[] temp1 = keys;
            T2[] temp2 = values;
            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];
            for (int i = 0; i < temp1.Length; i++)
            {
                keys[i] = temp1[i]; 
            }
            for (int i = 0; i < temp2.Length; i++)
            {
                values[i] = temp2[i];
            }
            keys[keys.Length - 1] = x;
            values[values.Length - 1] = y;
        }
        public int keyLength { get { return keys.Length; } }
        public T1[] KeyItems { get { return keys; } }
        public int valueLength { get { return values.Length; } }
        public T2[] ValueItems { get { return values; } }
        public void Value(int key)
        {
            Console.WriteLine(values[key]);
        }
    }
}
