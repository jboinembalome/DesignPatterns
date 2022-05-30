using Adapter.Commons;

namespace Adapter.Models;

internal class PdfDocument : IDocument
{
    protected PdfComponent pdfComponent = new();

    public string Content
    {
        set => pdfComponent.PdfUpdateContent(value);
    }

    public void Draw()
    {
        pdfComponent.PdfPrepareDisplay();
        pdfComponent.PdfRefresh();
        pdfComponent.PdfEndDisplay();
    }

    public void Print()
        => pdfComponent.PdfSendPrint();
}
