using System;

namespace PrototypeDeseni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { FirstName = "Celil", LastName = "Vural", City = "Denizli", Id = 1 };
            Customer customer2 = (Customer)customer1.Clone();
            customer2.FirstName = "Celil2";
            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
            Console.ReadLine();
        }
    }

    internal abstract class Person
    {
        public abstract Person Clone();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    internal class Customer : Person
    {
        public string City { get; set; }
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }

    internal class Employee : Person
    {
        public decimal Salary { get; set; }
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
