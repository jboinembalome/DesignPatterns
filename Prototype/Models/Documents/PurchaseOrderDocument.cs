namespace Prototype.Models.Documents;

internal class PurchaseOrderDocument : Document
{
    public override void Print()
        => Console.WriteLine($"Print the purchase order: {Client}");


    public override void Display() 
        => Console.WriteLine($"Display the purchase order: {Client}");
}
