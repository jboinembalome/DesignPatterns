namespace Builder.Models;

internal class HtmlBundle : Bundle
{
    public override void AddDocument(string document)
    {
        if (document.StartsWith("<HTML>"))
            Content.Add(document);
    }
    public override void Print()
    {
        Console.WriteLine("HTML bundle");

        foreach (string s in Content)
            Console.WriteLine(s);
    }
}

