namespace Prototype.Models.Documents;

internal class ApplicationRegistrationDocument : Document
{
    public override void Print()
        => Console.WriteLine($"Print the application for registration: {Client}");


    public override void Display() 
        => Console.WriteLine($"Display the application for registration: {Client}");
}
