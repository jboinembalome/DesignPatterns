using FactoryMethod.Models.Commands;

namespace FactoryMethod.Models.Clients;

internal abstract class Client
{
    protected IList<Command> Commands { get; set; } = new List<Command>();

    protected abstract Command CreateCommand(double amount);

    public void NewCommand(double amount)
    {
        Command command = CreateCommand(amount);
        if (command.Valid())
        {
            command.Pay();
            Commands.Add(command);
        }
    }
}
