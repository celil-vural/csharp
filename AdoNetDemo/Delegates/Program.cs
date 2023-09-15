using System;

namespace Delegates
{
    public delegate void MyDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate();
            myDelegate += customerManager.ShowAlert;//bu sayede iki fonksiyonu birden çalıştırabiliriz
            myDelegate();
        }
    }
    class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
    }
}
