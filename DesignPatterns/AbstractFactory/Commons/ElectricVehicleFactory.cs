using AbstractFactory.Interfaces;
using AbstractFactory.Models.Cars;
using AbstractFactory.Models.Scooters;

namespace AbstractFactory.Commons;

public class ElectricVehicleFactory : IVehicleFactory
{
    public Car CreateCar(string model, string colour, int power, double space)
        => new CarElectricity(model, colour, power, space);

    public Scooter CreateScooter(string model, string colour, int power)
        => new ScooterElectricity(model, colour, power);
}
