using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Customer
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public Customer()
        {
            
        }

        public Customer(int id, string customerNumber)
        {
            this.Id = id;
            this.CustomerNumber = customerNumber;
        }
    }
}
