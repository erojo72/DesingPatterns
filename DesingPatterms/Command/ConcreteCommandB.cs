using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ConcreteCommandB : ICommand
    {
        Receiver ReceiverObject;

        public ConcreteCommandB(Receiver receiver)
        {
            ReceiverObject = receiver;
        }

        public void Execute()
        {
            ReceiverObject.printB();
        }
    }
}
