namespace Adapter.Commons;

internal class PdfComponent
{
    protected string? Content { get; set; }

    public void PdfUpdateContent(string content)
        => Content = content;

    public void PdfPrepareDisplay()
        => Console.WriteLine("Display PDF document: Start");

    public void PdfRefresh()
        => Console.WriteLine($"Display content PDF : {Content}");

    public void PdfEndDisplay()
        => Console.WriteLine("Display PDF document: End");

    public void PdfSendPrint()
        => Console.WriteLine($"Print PDF : {Content}");
}
