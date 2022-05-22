namespace Builder.Models;

public class PdfBundle : Bundle
{
    public override void AddDocument(string document)
    {
        if (document.StartsWith("<PDF>"))
            content.Add(document);
    }
    public override void Print()
    {
        Console.WriteLine("PDF bundle");

        foreach (string s in content)
            Console.WriteLine(s);
    }
}

