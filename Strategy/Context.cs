using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Context
    {
        private IStrategy Strategy { get; set; }

        public Context(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            Strategy.Execute();
        }


    }
}
