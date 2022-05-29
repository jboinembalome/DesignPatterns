using Builder.Models;

namespace Builder.Commons;

internal abstract class CarBundleBuilder
{
    protected Bundle? bundle;

    public abstract void BuildOrderForm(string clientName);

    public abstract void BuildApplicationRegistration(string applicantName);

    public Bundle? GetBundle() => bundle;

    public Bundle? Result() => bundle;
}
