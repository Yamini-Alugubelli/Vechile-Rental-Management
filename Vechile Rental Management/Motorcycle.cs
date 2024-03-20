using System;

public class Motorcycle : Vehicle
{
    private string type;

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public Motorcycle(string model, string manufacturer, int year, double rentalPrice, string type)
        : base(model, manufacturer, year, rentalPrice)
    {
        Type = type;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Type: {Type}");
    }
}
