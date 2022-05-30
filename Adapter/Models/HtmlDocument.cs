namespace Adapter.Models;

internal class HtmlDocument : IDocument
{
    public string Content { protected get; set; } = string.Empty;

    public void Draw() 
        => Console.WriteLine($"Draw HTML document: {Content}");

    public void Print()
        => Console.WriteLine($"Print HTML document: {Content}");
}
