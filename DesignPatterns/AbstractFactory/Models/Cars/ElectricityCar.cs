namespace AbstractFactory.Models.Cars;

public class ElectricityCar : Car
{
    public ElectricityCar(string model, string colour, int power, double space)
        : base(model, colour, power, space)
    { }

    public override void ShowCharacteristics()
    {
        Console.WriteLine($"Electric car model: {Model}.");
        Console.WriteLine($"Colour: {Colour}.");
        Console.WriteLine($"Power: {Power}.");
        Console.WriteLine($"Space: {Space}. \n");
    }
}
