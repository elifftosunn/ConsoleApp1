using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 10;
            int s2 = 30;
            s1 = s2; 
            s2 = 65;
            Console.WriteLine(s1);
            int[] numbers1 = new int[] { 10, 20, 30, 40, 50 };
            int[] numbers2 = new int[] { 100, 200, 300, 400, 500 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]);
            Console.WriteLine(numbers1[0]+" "+numbers1[1]+" "+numbers1[2]);
            
            
            
            
            
            
            Customer customer = new Customer();
            customer.FirstName = "Ahmet";
            customer.CreditCardNumber = "123456789";

            Employee employee = new Employee();
            employee.FirstName = "Irmak";
            employee.EmployeeNumber = 42345356;
           
            Person person = customer;  
            customer.FirstName = "Ali";
            Console.WriteLine(person.FirstName);
           
            Console.WriteLine(((Customer)person).CreditCardNumber);
            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(employee);
            personManager.Add(person);
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
    }
   
    class Customer : Person 
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
