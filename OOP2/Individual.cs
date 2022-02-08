using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Individual:Customer => miras(inheritance)
    class Individual :Customer //Gerçek Müşteri de müşteridir demek
    {
        //bir veri üzerinde matematiksel işlem yapmıyorsak() ona string,char atamak daha verimli bir sonuç verir.
        public string TcNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        
    }
}
