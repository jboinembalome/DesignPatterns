using Builder.Models;

namespace Builder.Commons;

internal class PdfCarBundleBuilder : CarBundleBuilder
{
    public PdfCarBundleBuilder() => Bundle = new PdfBundle();

    public override void BuildOrderForm(string clientName) 
    {
        var document = $"<PDF>Order form client: {clientName}</PDF>";
        Bundle!.AddDocument(document);
    }

    public override void BuildApplicationRegistration(string applicantName)
    {
        var document = $"<PDF>Application registration applicant: {applicantName}</PDF>";
        Bundle!.AddDocument(document);
    }
}
