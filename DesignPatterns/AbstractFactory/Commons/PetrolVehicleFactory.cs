using AbstractFactory.Interfaces;
using AbstractFactory.Models.Cars;
using AbstractFactory.Models.Scooters;

namespace AbstractFactory.Commons;

public class PetrolVehicleFactory : IVehicleFactory
{
    public Car CreateCar(string model, string colour, int power, double space) 
        => new CarPetrol(model, colour, power, space);

    public Scooter CreateScooter(string model, string colour, int power) 
        => new ScooterPetrol(model, colour, power);
}