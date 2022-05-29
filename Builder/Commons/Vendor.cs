using Builder.Models;

namespace Builder.Commons;

internal class Vendor
{
    private readonly CarBundleBuilder _builder;

    public Vendor(CarBundleBuilder builder) => _builder = builder;

    public Bundle? Build(string clientName)
    {
        _builder.BuildPurchaseOrder(clientName);
        _builder.BuildApplicationRegistration(clientName);

        Bundle? bundle = _builder.Result();
        return bundle;
    }
}
