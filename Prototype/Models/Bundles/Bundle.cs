using Prototype.Models.Documents;

namespace Prototype.Models.Bundles;

internal abstract class Bundle
{
    public IList<Document>? Documents { get; protected set; }
}

