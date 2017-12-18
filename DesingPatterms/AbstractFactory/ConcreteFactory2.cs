using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ConcreteFactory2 : AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override ProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
