using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandDesignPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TextEditorController : ControllerBase
    {
        private readonly CommandInvoker _invoker;
        private readonly TextEditor _editor;

        public TextEditorController()
        {
            _invoker = new CommandInvoker();
            _editor = new TextEditor();
        }

        [HttpPut("update")]
        public IActionResult UpdateText([FromBody] string newText)
        {
            var command = new TextEditorCommand(_editor, newText);
            _invoker.ExecuteCommand(command);
            return Ok($"Metin güncellendi: {newText}");
        }

        [HttpDelete("undo")]
        public IActionResult Undo()
        {
            _invoker.UndoCommand();
            return Ok("Son işlem geri alındı.");
        }

        [HttpGet("get")]
        public IActionResult GetText()
        {
            return Ok(_editor.GetText());
        }
    }
}