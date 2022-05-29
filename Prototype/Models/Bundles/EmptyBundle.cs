using Prototype.Models.Documents;

namespace Prototype.Models.Bundles;

internal class EmptyBundle : Bundle
{
    private static EmptyBundle? _instance;

    private EmptyBundle()
        => Documents = new List<Document>();

    public static EmptyBundle Instance()
    {
        if (_instance == null)
            _instance = new EmptyBundle();
        return _instance;
    }

    public void Add(Document document) 
        => Documents!.Add(document);

    public void Remove(Document doc) 
        => Documents!.Remove(doc);
}
