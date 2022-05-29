// See https://aka.ms/new-console-template for more information
using FactoryMethod.Models.Clients;

Client client = new CashClient();
client.NewCommand(2000.0);
client.NewCommand(10000.0);

client = new CreditClient();
client.NewCommand(2000.0);
client.NewCommand(10000.0);