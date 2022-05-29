using Builder.Models;

namespace Builder.Commons;

internal class PdfCarBundleBuilder : CarBundleBuilder
{
    public PdfCarBundleBuilder() => Bundle = new PdfBundle();

    public override void BuildOrderForm(string clientName) 
    {
        string document = $"<PDF>Order form client: {clientName}</PDF>";
        Bundle!.AddDocument(document);
    }

    public override void BuildApplicationRegistration(string applicantName)
    {
        string document = $"<PDF>Application registration applicant: {applicantName}</PDF>";
        Bundle!.AddDocument(document);
    }
}
