using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ => Gerçek Müşteri
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.CustomerName = "Engin";
            customer1.CustomerLastName = "Demiroğ";
            customer1.TcNumber = "123456789";

            // Kodlama.io
            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "425325";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "3424253";

            //Müşteri class'i hem gerçek müşterinin referansını tutuyor hem de tüzel müşterinin referansını tutuyor.
            Customer customer3 = new Individual(); 
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
