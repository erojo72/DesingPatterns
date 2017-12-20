using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Invoker
    {
        List<ICommand> Commands = new List<ICommand>();

        public void SetCommand(ICommand command)
        {
            Commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach(var command in Commands)
                command.Execute();

            Commands.Clear();
        }
    }
}
