using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecoratorA : ComponentDecorator
    {
        public ConcreteDecoratorA(Component component)
        {
            WrappedObject = component;
        }

        public override void MethodA()
        {
            WrappedObject.MethodA();
            Console.WriteLine("Decorator A Method A");
            
        }

        public override void MethodB()
        {
            WrappedObject.MethodB();
            Console.WriteLine("Decorator A Method B");
        }
    }
}
