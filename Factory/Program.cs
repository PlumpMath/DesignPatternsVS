using System;

namespace Factory
{
    internal static class Program
    {
        private static void Main()
        {
            var creators = new Creater[2];

            creators[0] = new ConcreateCreaterA();
            creators[1] = new ConcreateCreaterB();
            foreach (var creator in creators)
            {
                var product = creator.FactoryMethod();
                Console.WriteLine("created {0}", product.GetType().Name);
            }
            Console.ReadKey();
        }
    }
    internal abstract class Product
    {
    }
    internal abstract class Creater
    {
        public abstract Product FactoryMethod();
    }
}
