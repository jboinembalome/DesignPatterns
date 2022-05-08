// See https://aka.ms/new-console-template for more information
using AbstractFactory.Commons;
using AbstractFactory.Interfaces;
using AbstractFactory.Models.Cars;
using AbstractFactory.Models.Scooters;

#region Private Fields
const int NUMBER_OF_CARS = 3;
const int NUMBER_OF_SCOOTERS = 2;
var cars = new Car[NUMBER_OF_CARS];
var scooters = new Scooter[NUMBER_OF_SCOOTERS];
IVehicleFactory? factory = null;
#endregion

// Create the factory according to the choice of the user.
var validChoice = false;
while (!validChoice)
{
    Console.WriteLine("Do you want to use electric (1) or petrol (2) vehicles?");
    var choice = Console.ReadLine();

    factory = CreateFactory(choice);
    if (factory != null)
        validChoice = true;
    else
    {
        validChoice = false;
        Console.WriteLine($"Error: The choice {choice} is not valid. \n");
    }      
}

// Create all vehicles
for (var i = 0; i < NUMBER_OF_CARS; i++)
    cars[i] = factory!.CreateCar("Standard", "Yellow", 6 + i, 3.2);
for (var i = 0; i < NUMBER_OF_SCOOTERS; i++)
    scooters[i] = factory!.CreateScooter("Classic", "Red", 2 + i);

// Show characteristics for all vehicles
foreach (var car in cars)
    car.ShowCharacteristics();
foreach (var scooter in scooters)
    scooter.ShowCharacteristics();

#region Private Functions
static IVehicleFactory? CreateFactory(string? choice) => choice switch
{
    "1" => new ElectricVehicleFactory(),
    "2" => new PetrolVehicleFactory(),
    _ => null,
};
#endregion
