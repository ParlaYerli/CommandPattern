using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            CommandInvoker invoker = new CommandInvoker();

            var command1 = new TextEditorCommand(editor, "Merhaba dünya!");
            invoker.ExecuteCommand(command1);


            var command2 = new TextEditorCommand(editor, "Hello World!");
            invoker.ExecuteCommand(command1);

            var command3 = new TextEditorCommand(editor, "Command Pattern ile Undo işlemi!");
            invoker.ExecuteCommand(command2);

            invoker.UndoCommand(); // Son yapılan işlemi geri alır
           // invoker.UndoCommand(); // Önceki işlemi geri alır
        }
    }
}
