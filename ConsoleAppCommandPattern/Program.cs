using System;

namespace ConsoleAppCommandPattern
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
            invoker.ExecuteCommand(command2);

            var command3 = new TextEditorCommand(editor, "Son Islem!");
            invoker.ExecuteCommand(command3);

            invoker.UndoCommand(); 

            Console.ReadLine();
        }
    }
}
