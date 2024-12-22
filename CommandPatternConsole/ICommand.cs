namespace CommandPatternConsole
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}