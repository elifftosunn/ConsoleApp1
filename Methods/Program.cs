using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONT REPEAT YOURSELF (KENDİNİ TEKRAR ETME) - DRY - Clean Code - Best Practice
            Product product1 = new Product() { Id=1,Name="Erik",Price="5",Explanation="Green Erik "};
            Product product2 = new Product() { Id=1,Name="Armut",Price="10",Explanation="Small Armut "};
            Product product3 = new Product() { Id=1,Name="Elma",Price="15",Explanation="Red Elma "};

            Product[] product = new Product[] { product1, product2, product3 };
            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine("Ürün id: "+product[i].Id+" Ürün adı: "+product[i].Name+" Ürün fiyatı: "+product[i].Price+" Ürün açıklama: "+product[i].Explanation);
            }
            Console.WriteLine("*********************************");
            BasketManager basket = new BasketManager();
            basket.Add(product1);
            basket.Add(product2);
            basket.Add2("Kiraz", "Kırmızı", 6.5,10);
            basket.Add2("Armut", "Sarı", 8.25,9);
            basket.Add2("Erik", "Yeşil", 12,8);
        }
    }
}
