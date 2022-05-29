namespace FactoryMethod.Models.Commands;

internal class CashCommand : Command
{
    public CashCommand(double amount)
        : base(amount) { }

    public override void Pay()
        => Console.WriteLine($"The payment of the command in cash of: {Amount} is made.");

    public override bool Valid() => true;
}

