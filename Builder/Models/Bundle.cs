namespace Builder.Models;

public abstract class Bundle
{
    protected IList<string> content = new List<string>();

    public abstract void AddDocument(string document);
    public abstract void Print();
}

