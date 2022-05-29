namespace Prototype.Models.Documents;

internal class AssignmentCertificateDocument : Document
{
    public override void Print()
        => Console.WriteLine($"Print the certificate of assignment: {Client}");

    public override void Display() 
        => Console.WriteLine($"Display the certificate of assignment: {Client}");
}
