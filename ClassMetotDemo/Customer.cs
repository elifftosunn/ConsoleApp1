using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassMetotDemo
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string surName { get; set; }
        public string email { get; set; }
        public int customerNo { get; set; }
        public Customer(int id,string name, string surName, string email)
        {
            this.Id = id;
            this.Name = name;
            this.surName = surName;
            this.email = email;
            this.customerNo = customerNo;
        }
        public Customer()
        {

        }
    }
}
