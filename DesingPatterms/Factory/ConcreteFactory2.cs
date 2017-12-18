using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ConcreteFactory2 : Factory
    {
        public override Product CreateProduct(string type)
        {
            Product product = null;
            
            if (type == "A")
            {
                product = new ProductA();
            }
            else if (type == "B")
            {
                product = new ProductB();
            }

            if (product != null) product.State = 2;

            return product;
        }
    }
}
