using Builder.Models;

namespace Builder.Commons;

internal class PdfCarBundleBuilder : CarBundleBuilder
{
    public PdfCarBundleBuilder() => bundle = new PdfBundle();

    public override void BuildOrderForm(string clientName) 
    {
        string document = $"<PDF>Order form client: {clientName}</PDF>";
        bundle!.AddDocument(document);
    }

    public override void BuildApplicationRegistration(string applicantName)
    {
        string document = $"<PDF>Application registration applicant: {applicantName}</PDF>";
        bundle!.AddDocument(document);
    }
}
