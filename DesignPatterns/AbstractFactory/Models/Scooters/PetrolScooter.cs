namespace AbstractFactory.Models.Scooters;

internal class PetrolScooter : Scooter
{
    public PetrolScooter(string model, string colour, int power)
        : base(model, colour, power)
    { }

    public override void ShowCharacteristics()
    {
        Console.WriteLine($"Petrol scooter model: {Model}.");
        Console.WriteLine($"Colour: {Colour}.");
        Console.WriteLine($"Power: {Power}.");
    }

}
