using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public List<Customer> customer = new List<Customer>();
        public void newCustomer(int id,string name, string surname,string email)
        {
            this.customer.Add(new Customer(id,name,surname,email));
        }
        public void deleteCustomer(int id)
        {
            Customer c = this.customer.Where(x => x.Id == id).FirstOrDefault();
            if (c != null)
            {
                this.customer.Remove(c);
                Console.WriteLine("\n"+id+" id'li müşteri silindi.\n");
            }
            else
            {
                throw new Exception("Silinecek müşteri bulunamadı.");
            }
        }
        public void ListCustomer()
        {
            Console.WriteLine("Id".PadRight(10) + "Name".PadRight(10) + "SurName".PadRight(10) + "Email");
            Console.WriteLine("".PadRight(45, '-'));
            foreach (var item in customer)
            {
                Console.WriteLine(item.Id.ToString().PadRight(10) + item.Name.PadRight(10) + item.surName.PadRight(10) + item.email);
            }
        }
        
    }
}
