internal class Program
{
    private static void Main(string[] args)
    {
        IPerson person = new Customer{Adress="adress",FirstName="first name",LastName="last name",Name="name"};
    }
    
    
}
interface IPerson
{
    string Name { get; }
    string FirstName { get; }
    string LastName { get; }
}
internal class Customer : IPerson
{  
    
    public string Name { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
    public string Adress { get; set; }
}