using System;

public class Truck : Vehicle
{
    private double cargoCapacity;

    public double CargoCapacity
    {
        get { return cargoCapacity; }
        set { cargoCapacity = value; }
    }

    public Truck(string model, string manufacturer, int year, double rentalPrice, double cargoCapacity)
        : base(model, manufacturer, year, rentalPrice)
    {
        CargoCapacity = cargoCapacity;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Cargo Capacity: {CargoCapacity}");
    }
}
