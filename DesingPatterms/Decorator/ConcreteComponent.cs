using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteComponent : Component
    {
        public override void MethodA()
        {
            Console.WriteLine("Component Method A");
        }

        public override void MethodB()
        {
            Console.WriteLine("Component Method B");
        }
    }
}
