using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class Factory
    {
        public abstract Product CreateProduct(string type);
    }
}
