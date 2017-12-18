using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteFactory1 factory1 = new ConcreteFactory1();

            Console.WriteLine(factory1.CreateProductA().GetType());
            Console.WriteLine(factory1.CreateProductB().GetType());

            ConcreteFactory2 factory2 = new ConcreteFactory2();
            Console.WriteLine(factory2.CreateProductA().GetType());
            Console.WriteLine(factory2.CreateProductB().GetType());

            Console.ReadLine();

        }
    }
}
