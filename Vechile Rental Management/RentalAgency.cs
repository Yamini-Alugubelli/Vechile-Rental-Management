namespace Assignment3;

public class RentalAgency
{
    private Vehicle[] Fleet { get; set; }
    public decimal TotalRevenue { get; private set; }

    public RentalAgency(int fleetSize)
    {
        Fleet = new Vehicle[fleetSize];
    }
    //AddVechile method
    public void addVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] == null)
            {
                Fleet[i] = vehicle;
                return;
            }
        }

        Console.WriteLine("The fleet is full.");
    }
    //Remove Vechile method
    public void removeVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] != null && Fleet[i].GetType() == vehicle.GetType())
            {
                Fleet[i] = null;
                return;
            }
        }

        Console.WriteLine("The vehicle is not in the fleet.");
    }
    //Rent Vechile method
    public void rentVehicle(Vehicle vehicle)
    {
        if (Fleet.Any(v => v == vehicle))
        {
            Console.WriteLine("Vehicle rented.");
            TotalRevenue += vehicle.RentalPrice;
        }
        else
        {
            Console.WriteLine("The vehicle is not in the fleet.");
        }
    }
}