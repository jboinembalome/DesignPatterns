namespace AbstractFactory.Models.Scooters;

public class ScooterElectricity : Scooter
{
    public ScooterElectricity(string model, string colour, int power)
        : base(model, colour, power)
    { }

    public override void ShowCharacteristics()
    {
        Console.WriteLine($"Electric scooter model: {Model}.");
        Console.WriteLine($"Colour: {Colour}.");
        Console.WriteLine($"Power: {Power}.");
    }
}
