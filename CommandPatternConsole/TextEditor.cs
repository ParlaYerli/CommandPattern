using DevExpress.Xpo;
using System;

namespace CommandPatternConsole
{
    public class TextEditor
    {
        private string _text;

        public void SetText(string text)
        {
            _text = text;
            Console.WriteLine("Metin güncellendi: " + _text);
        }

        public string GetText()
        {
            return _text;
        }
    }
}