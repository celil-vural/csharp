using System;

namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50) { ProductName = "Hard Disk" };
            Product gsm = new Product(50) { ProductName = "Gsm" };
            gsm.StockControlEvent += Gsm_StockControlEvent;
            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("GSM about to finish!!!");
        }
    }
}
