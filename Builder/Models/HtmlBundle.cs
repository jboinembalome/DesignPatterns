namespace Builder.Models;

internal class HtmlBundle : Bundle
{
    public override void AddDocument(string document)
    {
        if (document.StartsWith("<HTML>"))
            content.Add(document);
    }
    public override void Print()
    {
        Console.WriteLine("HTML bundle");

        foreach (string s in content)
            Console.WriteLine(s);
    }
}

