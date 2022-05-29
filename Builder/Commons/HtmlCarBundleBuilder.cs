using Builder.Models;

namespace Builder.Commons;

internal class HtmlCarBundleBuilder : CarBundleBuilder
{
    public HtmlCarBundleBuilder() => Bundle = new HtmlBundle();

    public override void BuildOrderForm(string clientName) 
    {
        var document = $"<HTML>Order form client: {clientName}</HTML>";
        Bundle!.AddDocument(document);
    }

    public override void BuildApplicationRegistration(string applicantName)
    {
        var document = $"<HTML>Application registration applicant: {applicantName}</HTML>";
        Bundle!.AddDocument(document);
    }
}
