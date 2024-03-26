using System.Reflection;
namespace Assignment3;

public class Truck : Vehicle
{
    public int Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }
    //Truck constructor
    public Truck(string model, string manufacturer, int year, decimal rentalPrice, int capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice)
    {
    Capacity = capacity;
    TruckType = truckType;
    FourWheelDrive = fourWheelDrive;
}
    //DisplayDetails Method
    public override void displayDetails()
{
    base.displayDetails();
    Console.WriteLine($"Capacity: {Capacity}");
    Console.WriteLine($"Truck Type: {TruckType}");
    Console.WriteLine($"Four Wheel Drive: {FourWheelDrive}");
}
}