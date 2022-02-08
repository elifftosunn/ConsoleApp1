using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Product
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public double unitPrice { get; set; }
        public int MyProperty { get; set; }
        public int CategoryId { get; set; }
        public int UnitsInStock { get; set; } //ürünün stok adedi
    }
}
