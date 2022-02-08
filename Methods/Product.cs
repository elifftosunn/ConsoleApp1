using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Product //public => erişim belirleyici
    {
        //Property - özellik
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Explanation { get; set; } //Açıklama
        public int stokAdedi { get; set; }
    }
}
