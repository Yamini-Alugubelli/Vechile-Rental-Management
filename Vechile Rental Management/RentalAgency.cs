using System;
using System.Collections.Generic;

public class RentalAgency
{
    private List<Vehicle> vehicles;

    public RentalAgency()
    {
        vehicles = new List<Vehicle>();
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void DisplayAllVehiclesDetails()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayDetails();
        }
    }
}
