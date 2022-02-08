using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Elif");
            myDictionary.Add(2, "Selen");
            myDictionary.Add(3, "Deniz");
            myDictionary.Add(4, "Ahmet");
            for (int i = 0; i < myDictionary.keyLength; i++)
            {
                myDictionary.Value(i);
            }

        }
    }
}
