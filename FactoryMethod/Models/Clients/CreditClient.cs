using FactoryMethod.Models.Commands;

namespace FactoryMethod.Models.Clients;

internal class CreditClient : Client
{
    protected override Command CreateCommand(double amount) 
        => new CreditCommand(amount);
}
