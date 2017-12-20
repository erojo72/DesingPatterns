using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();

            ConcreteCommandA commandA = new ConcreteCommandA(receiver);

            ConcreteCommandB commandB = new ConcreteCommandB(receiver);

            Invoker invoker = new Invoker();

            invoker.SetCommand(commandA);

            invoker.SetCommand(commandB);

            invoker.ExecuteCommands();

            Console.ReadLine();
        }
    }
}
