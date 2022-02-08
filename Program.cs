using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();

            Customer customer1 = new Customer() { Id = 1, Name = "Akın", surName = "Yılmaz", email="info@gmail.com" ,customerNo=10};
            Customer customer2 = new Customer() { Id = 2, Name = "Deniz", surName = "Yılmaz", email="info1@gmail.com",customerNo=20 };
            Customer customer3 = new Customer() { Id = 3, Name = "Selin", surName = "Yılmaz", email="info2@gmail.com" ,customerNo=30};
            Customer customer4 = new Customer() { Id = 4, Name = "İrem", surName = "Yılmaz", email = "info3@gmail.com",customerNo=40 };

            customer.newCustomer(customer1.Id,customer1.Name, customer1.surName, customer1.email);
            customer.newCustomer(customer2.Id,customer2.Name, customer2.surName, customer2.email);
            customer.newCustomer(customer3.Id,customer3.Name, customer3.surName, customer3.email);
            customer.newCustomer(customer4.Id,customer4.Name, customer4.surName, customer4.email);
            customer.ListCustomer();
            customer.deleteCustomer(1);
            customer.ListCustomer();

        }
    }
}
