namespace CommandPatternConsole
{
    public class TextEditorCommand : ICommand
    {
        private string _text;
        private string _previousText;
        private TextEditor _textEditor;

        public TextEditorCommand(TextEditor textEditor, string newText)
        {
            _textEditor = textEditor;
            _text = newText;
        }

        public void Execute()
        {
            _previousText = _textEditor.GetText();
            _textEditor.SetText(_text);
        }

        public void Undo()
        {
            _textEditor.SetText(_previousText);
        }
    }

}