namespace Builder.Models;

internal abstract class Bundle
{
    protected IList<string> Content { get; set; } = new List<string>();

    public abstract void AddDocument(string document);
    public abstract void Print();
}

