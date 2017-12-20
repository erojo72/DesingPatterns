using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ConcreteCommandA : ICommand
    {
        Receiver ReceiverObject;

        public ConcreteCommandA(Receiver receiver)
        {
            ReceiverObject = receiver;
        }

        public void Execute()
        {
            ReceiverObject.printA();
        }
    }
}
