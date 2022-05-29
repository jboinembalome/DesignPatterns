namespace FactoryMethod.Models.Commands;

internal abstract class Command
{
    public double Amount { get; set; }

    public Command(double amount) => Amount = amount;

    public abstract bool Valid();

    public abstract void Pay();
}

