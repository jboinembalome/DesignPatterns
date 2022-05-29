using Builder.Models;

namespace Builder.Commons;

internal class HtmlCarBundleBuilder : CarBundleBuilder
{
    public HtmlCarBundleBuilder() => Bundle = new HtmlBundle();

    public override void BuildPurchaseOrder(string clientName) 
    {
        var document = $"<HTML>Purchase order from the client: {clientName}</HTML>";
        Bundle!.AddDocument(document);
    }

    public override void BuildApplicationRegistration(string applicantName)
    {
        var document = $"<HTML>Application registration applicant: {applicantName}</HTML>";
        Bundle!.AddDocument(document);
    }
}
