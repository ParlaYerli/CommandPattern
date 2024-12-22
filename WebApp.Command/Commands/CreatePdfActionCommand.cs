using Microsoft.AspNetCore.Mvc;

namespace WebApp.Command.Commands
{
    public class CreatePdfActionCommand<T> : ITableActionCommand
    {
        private readonly PdfFile<T> _pdfFile;

        public CreatePdfActionCommand(PdfFile<T> pdfFile)
        {
            _pdfFile = pdfFile;
        }

        public IActionResult Execute()
        {
            var excelMemoryStream = _pdfFile.Create();

            return new FileContentResult(excelMemoryStream.ToArray(), _pdfFile.FileType) { FileDownloadName = _pdfFile.FileName };
        }
    }
}