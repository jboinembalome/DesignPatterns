using Builder.Models;

namespace Builder.Commons;

internal class Vendor
{
    protected CarBundleBuilder Builder { get; set; }

    public Vendor(CarBundleBuilder builder)
    {
        Builder = builder;
    }

    public Bundle? Build(string clientName)
    {
        Builder.BuildOrderForm(clientName);
        Builder.BuildApplicationRegistration(clientName);

        Bundle? bundle = Builder.Result();
        return bundle;
    }
}
