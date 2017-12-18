using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecoratorB : ComponentDecorator
    {
        public ConcreteDecoratorB(Component component)
        {
            WrappedObject = component;
        }

        public override void MethodA()
        {
            WrappedObject.MethodA();
            Console.WriteLine("Decorator B Method A");
            
        }

        public override void MethodB()
        {
            WrappedObject.MethodB();
            Console.WriteLine("Decorator B Method B");
        }
    }
}
