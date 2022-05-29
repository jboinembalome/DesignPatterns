namespace Prototype.Models.Clients;

internal class Client
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? Birthday { get; set; }

    public override string ToString() 
        => $"{Id} {FirstName} {LastName} {Birthday}";
}
