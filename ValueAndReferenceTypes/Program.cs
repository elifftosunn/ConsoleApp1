using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int,decimal,float,double,bool => değer tip (stack)
            // array, class, interface => referans tip (heap) => pointer(c++)
            int s1 = 10;
            int s2 = 30;
            s1 = s2; // sadece deger ataması yapılır.
            s2 = 65;
            Console.WriteLine(s1);
            // new => demek bellekten(heap) bir yer oluştur demek
            int[] numbers1 = new int[] { 10, 20, 30, 40, 50 };
            int[] numbers2 = new int[] { 100, 200, 300, 400, 500 };
            numbers1 = numbers2; //numbers1'in referansı artık numbers2'nin referansını gösteriyor.
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]); //numbers1'in heap'teki yeri artık numbers2'nin heap'teki yeri olduğundan numbers2'nin degerlerini degistirdigimizde numbers1'in degerleri de degisecektir.
            Console.WriteLine(numbers1[0]+" "+numbers1[1]+" "+numbers1[2]);
            
            
            
            
            
            
            Customer customer = new Customer();
            customer.FirstName = "Ahmet";
            customer.CreditCardNumber = "123456789";

            Employee employee = new Employee();
            employee.FirstName = "Irmak";
            employee.EmployeeNumber = 42345356;
            //base sınıfa(Person) onu inherit eden sınıfın referansları atanır.
            Person person = customer;  // person customer'in adresini tutuyor.
            customer.FirstName = "Ali";
            Console.WriteLine(person.FirstName);
            //ama biz customer özelliğini(CreditCardNumber) person'da göremiyoruz. Özelliğini görebilmemiz için =>
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
    // BASE CLASS : Person 
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
