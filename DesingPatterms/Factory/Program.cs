using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteFactory factory = new ConcreteFactory();

            var productA = factory.CreateProduct("A");

            var productB = factory.CreateProduct("B");

            Console.WriteLine(productA.GetType() + " " + productA.State);

            Console.WriteLine(productB.GetType() + " " + productB.State);

            ConcreteFactory2 factory2 = new ConcreteFactory2();

            var productA2 = factory2.CreateProduct("A");

            var productB2 = factory2.CreateProduct("B");

            Console.WriteLine(productA2.GetType() + " " + productA2.State);

            Console.WriteLine(productB2.GetType() + " " + productB2.State);

            Console.ReadLine();
        }
    }
}
