using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        // naming convention
        // syntax => Yazım metotları
        // Kapsülleme (Encapsulation) => Ayrı ayrı yazmak yerine düzene sokar.
        public void Add(Product product) //Kapsülleme (Encapsulation) 
        {
            Console.WriteLine(product.Name+" sepete eklendi.");
        }
        public void Add2(string productName,string explanation,double price,int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: "+productName);
        }

    }
}
