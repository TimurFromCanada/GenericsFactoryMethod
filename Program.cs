using System;

namespace GenericsFactoryMethod
{
    class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
