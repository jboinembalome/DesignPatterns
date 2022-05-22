using Builder.Models;

namespace Builder.Commons;

public class HtmlCarBundleBuilder : CarBundleBuilder
{
    public HtmlCarBundleBuilder() => bundle = new HtmlBundle();

    public override void BuildOrderForm(string clientName) 
    {
        string document = $"<HTML>Order form client: {clientName}</HTML>";
        bundle!.AddDocument(document);
    }

    public override void BuildApplicationRegistration(string applicantName)
    {
        string document = $"<HTML>Application registration applicant: {applicantName}</HTML>";
        bundle!.AddDocument(document);
    }
}
