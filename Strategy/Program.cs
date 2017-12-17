using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStrategyA());

            context.ExecuteStrategy();

            context.SetStrategy(new ConcreteStrategyB());

            context.ExecuteStrategy();

            context.SetStrategy(new ConcreteStrategyC());

            context.ExecuteStrategy();

            Console.ReadLine();
        }

        public class A
        {
            public void aa() { }
        }
    }

}
