using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(DortIslem);
            //DortIslem dortIslem=(DortIslem)Activator.CreateInstance(type,6,7);
            var instance = Activator.CreateInstance(type, 6, 7);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            var methods = type.GetMethods();

            int result = (int)methodInfo.Invoke(instance, null);//null olan kısma varsa fonk parametreleri
        }
    }
    internal class DortIslem
    {
        int _sayi1, _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }
        public int Carp(params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
    }
}
