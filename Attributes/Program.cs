using System;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

    }
    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string Name { get; set; }
        [RequiredProperty]
        public string Address { get; set; }
    }
    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}{1}{2} added", customer.Id, customer.Name, customer.Address);
        }
    }
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
