using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Cars;

internal abstract class Car : IVehicle
{
    protected string Model { get; set; }
    protected string Colour { get; set; }
    protected int Power { get; set; }
    protected double Space { get; set; }

    public Car(string model, string colour, int power, double space)
    {
        Model = model;
        Colour = colour;
        Power = power;
        Space = space;
    }

    public abstract void ShowCharacteristics();
}
