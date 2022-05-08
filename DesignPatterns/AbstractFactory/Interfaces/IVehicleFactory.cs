using AbstractFactory.Models.Cars;
using AbstractFactory.Models.Scooters;

namespace AbstractFactory.Interfaces;

public interface IVehicleFactory
{
    /// <summary>
    /// Create a car.
    /// </summary>
    /// <param name="model"></param>
    /// <param name="colour"></param>
    /// <param name="power"></param>
    /// <param name="space"></param>
    /// <returns></returns>
    Car CreateCar(string model, string colour, int power, double space);

    /// <summary>
    /// Create a scooter.
    /// </summary>
    /// <param name="model"></param>
    /// <param name="colour"></param>
    /// <param name="power"></param>
    /// <returns></returns>
    Scooter CreateScooter(string model, string colour, int power);
}
