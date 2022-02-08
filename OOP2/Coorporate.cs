using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Coorporate:Customer => miras(inheritance)
    // Coorporate(tüzel müşterinin) ebeveyni (Customer)müşteri
    class Coorporate :Customer //Tüzel Müşteri bir müşteridir demek
    {
        //bir veri üzerinde matematiksel işlem yapmıyorsak() ona string,char atamak daha verimli bir sonuç verir.
       
        public string CompanyName { get; set; } //Şirket Adı
        public string TaxNo { get; set; } //vergi no

    }
}
