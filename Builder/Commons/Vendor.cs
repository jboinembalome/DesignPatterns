using Builder.Models;

namespace Builder.Commons;

public class Vendor
{
    protected CarBundleBuilder _builder;

    public Vendor(CarBundleBuilder builder)
    {
        _builder = builder;
    }

    public Bundle? Build(string clientName)
    {
        _builder.BuildOrderForm(clientName);
        _builder.BuildApplicationRegistration(clientName);

        Bundle? bundle = _builder.Result();
        return bundle;
    }
}
