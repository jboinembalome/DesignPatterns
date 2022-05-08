namespace AbstractFactory.Models.Scooters;

public class ScooterPetrol : Scooter
{
    public ScooterPetrol(string model, string colour, int power)
        : base(model, colour, power)
    { }

    public override void ShowCharacteristics()
    {
        Console.WriteLine($"Petrol scooter model: {Model}.");
        Console.WriteLine($"Colour: {Colour}.");
        Console.WriteLine($"Power: {Power}.");
    }

}
