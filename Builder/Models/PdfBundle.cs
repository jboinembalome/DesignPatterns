namespace Builder.Models;

internal class PdfBundle : Bundle
{
    public override void AddDocument(string document)
    {
        if (document.StartsWith("<PDF>"))
            Content.Add(document);
    }
    public override void Print()
    {
        Console.WriteLine("PDF bundle");

        foreach (string s in Content)
            Console.WriteLine(s);
    }
}

