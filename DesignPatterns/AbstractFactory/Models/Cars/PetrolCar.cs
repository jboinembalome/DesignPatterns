namespace AbstractFactory.Models.Cars;
internal class PetrolCar : Car
{
    public PetrolCar(string model, string colour, int power, double space)
        : base(model, colour, power, space)
    { }

    public override void ShowCharacteristics()
    {
        Console.WriteLine($"Petrol car model: {Model}.");
        Console.WriteLine($"Colour: {Colour}.");
        Console.WriteLine($"Power: {Power}.");
        Console.WriteLine($"Space: {Space}. \n");
    }
}
