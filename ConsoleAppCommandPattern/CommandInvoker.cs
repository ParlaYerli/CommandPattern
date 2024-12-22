using System;
using System.Collections.Generic;

namespace ConsoleAppCommandPattern
{
    public class CommandInvoker
    {
        private Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }
        public void UndoCommand()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand command = _commandHistory.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine("Geri alınacak işlem bulunmuyor.");
            }
        }
    }
}
