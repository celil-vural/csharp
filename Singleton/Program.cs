namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = CustomerManager.CreateSingletonCustomerManager();
        }
    }

    public class CustomerManager
    {
        private static CustomerManager _customerManager;
        private static object _lockObject = new object();
        private CustomerManager() { }

        public static CustomerManager CreateSingletonCustomerManager()
        {
            /*return _customerManager ?? (lock (_lockObject)
            {
                _customerManager = new CustomerManager();
            });*/
            lock (_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }

            }
            return _customerManager;
        }
    }
}
