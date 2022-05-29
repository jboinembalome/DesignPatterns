using AbstractFactory.Interfaces;
using AbstractFactory.Models.Cars;
using AbstractFactory.Models.Scooters;

namespace AbstractFactory.Commons;

internal class PetrolVehicleFactory : IVehicleFactory
{
    public Car CreateCar(string model, string colour, int power, double space) 
        => new PetrolCar(model, colour, power, space);

    public Scooter CreateScooter(string model, string colour, int power) 
        => new PetrolScooter(model, colour, power);
}
