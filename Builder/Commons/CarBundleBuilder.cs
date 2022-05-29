using Builder.Models;

namespace Builder.Commons;

internal abstract class CarBundleBuilder
{
    protected Bundle? Bundle { get; set; }

    public abstract void BuildPurchaseOrder(string clientName);

    public abstract void BuildApplicationRegistration(string applicantName);

    public Bundle? GetBundle() => Bundle;

    public Bundle? Result() => Bundle;
}
