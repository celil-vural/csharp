using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager _productManager = new ProductManager(new Factory1());
            _productManager.GetAll();
        }
    }

    internal abstract class Logging
    {
        public abstract void Log(string message);
    }

    internal class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logging with Log4NetLogger {0}", message);
        }
    }
    internal class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logging with NLogger {0}", message);
        }
    }

    internal abstract class Caching
    {
        public abstract void Cache(string data);
    }

    internal class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Caching with MemCache:{0}", data);
        }
    }

    internal abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogging();
        public abstract Caching CreateCaching();
    }

    internal class Factory1 : CrossCuttingConcernsFactory
    {
        public override Logging CreateLogging()
        {
            return new Log4NetLogger();
        }

        public override Caching CreateCaching()
        {
            return new MemCache();
        }
    }

    internal class ProductManager
    {
        private CrossCuttingConcernsFactory _crossCuttingConcernsFactory;
        private Logging _logging;
        private Caching _caching;
        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _logging = _crossCuttingConcernsFactory.CreateLogging();
            _caching = _crossCuttingConcernsFactory.CreateCaching();
        }

        public void GetAll()
        {
            _logging.Log("Log");
            _caching.Cache("Data");
            Console.WriteLine("Product Listed");
        }
    }
}
