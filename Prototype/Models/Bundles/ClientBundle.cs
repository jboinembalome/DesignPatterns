using Prototype.Models.Clients;
using Prototype.Models.Documents;

namespace Prototype.Models.Bundles;

internal class ClientBundle : Bundle
{
    public ClientBundle(Client client)
    {
        Documents = new List<Document>();
        EmptyBundle emptyBundle = EmptyBundle.Instance();
        IList<Document> emptyDocuments = emptyBundle.Documents!;

        foreach (var document in emptyDocuments)
        {
            Document copiedDocument = document.Duplicate();
            copiedDocument.FillClientInformation(client);
            Documents.Add(copiedDocument);
        }
    }

    public void DisplayDocuments()
    {
        foreach (Document document in Documents!)
            document.Display();
    }

    public void PrintDocuments()
    {
        foreach (Document document in Documents!)
            document.Print();
    }
}
