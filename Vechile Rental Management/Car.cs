using System;

public class Car : Vehicle
{
    private int numberOfSeats;

    public int NumberOfSeats
    {
        get { return numberOfSeats; }
        set { numberOfSeats = value; }
    }

    public Car(string model, string manufacturer, int year, double rentalPrice, int numberOfSeats)
        : base(model, manufacturer, year, rentalPrice)
    {
        NumberOfSeats = numberOfSeats;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Number of Seats: {NumberOfSeats}");
    }
}
