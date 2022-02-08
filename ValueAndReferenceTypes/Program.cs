using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int,decimal,float,double,bool => değer tip (stack)
            // array, class, interface => referans tip (heap) => pointer(c++)
            int s1 = 10;
            int s2 = 30;
            s1 = s2; // sadece deger ataması yapılır.
            s2 = 65;
            Console.WriteLine(s1);
            // new => demek bellekten(heap) bir yer oluştur demek
            int[] numbers1 = new int[] { 10, 20, 30, 40, 50 };
            int[] numbers2 = new int[] { 100, 200, 300, 400, 500 };
            numbers1 = numbers2; //numbers1'in referansı artık numbers2'nin referansını gösteriyor.
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]); //numbers1'in heap'teki yeri artık numbers2'nin heap'teki yeri olduğundan numbers2'nin degerlerini degistirdigimizde numbers1'in degerleri de degisecektir.
            Console.WriteLine(numbers1[0]+" "+numbers1[1]+" "+numbers1[2]);
        }
    }
}
