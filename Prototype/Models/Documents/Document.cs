using Prototype.Models.Clients;

namespace Prototype.Models.Documents;

internal abstract class Document
{
    public Client? Client { get; set; }

    public Document Duplicate()
    {
        Document result;
        result = (Document)MemberwiseClone();
        return result;
    }

    public abstract void Display();
    public abstract void Print();

    public void FillClientInformation(Client client) => Client = client;
}

