namespace FactoryMethod.Models.Commands;

internal class CreditCommand : Command
{
    public CreditCommand(double amount)
        : base(amount) { }

    public override void Pay()
        => Console.WriteLine($"The payment of the command in credit of: {Amount} is made.");

    public override bool Valid() => (Amount >= 1000.0) && (Amount <= 5000.0);
}

