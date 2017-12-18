using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent component = new ConcreteComponent();
            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA(component);
            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB(decoratorA);
            ConcreteDecoratorB decoratorB2 = new ConcreteDecoratorB(decoratorB);

            decoratorB2.MethodA();
            decoratorB2.MethodB();

            Console.ReadLine();

        }
    }
}
