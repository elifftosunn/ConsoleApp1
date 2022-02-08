using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { Id=2,CategoryId=5,productName="Kalem",unitPrice=35,UnitsInStock=5};
            Product product2 = new Product() { Id=3,CategoryId=10,productName="Masa",unitPrice=500,UnitsInStock=3};
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);  //bellek
            Console.WriteLine(product1.productName);


            /*
            int number = 100; //value
            productManager.Any(number);
            Console.WriteLine(number);*/

            int sumResult=productManager.Topla(3, 5);
            Console.WriteLine(sumResult*2);
            //productManager.Topla2(3, 5);


        
        }
    }
}
