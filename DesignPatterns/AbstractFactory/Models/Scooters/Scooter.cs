using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Scooters;

internal abstract class Scooter : IVehicle
{
    protected string Model { get; set; }
    protected string Colour { get; set; }
    protected int Power { get; set; }

    public Scooter(string modele, string couleur, int puissance)
    {
        Model = modele;
        Colour = couleur;
        Power = puissance;
    }

    public abstract void ShowCharacteristics();
}
