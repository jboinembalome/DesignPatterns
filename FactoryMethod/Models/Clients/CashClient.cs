using FactoryMethod.Models.Commands;

namespace FactoryMethod.Models.Clients;

internal class CashClient : Client
{
    protected override Command CreateCommand(double amount) 
        => new CashCommand(amount);
}
