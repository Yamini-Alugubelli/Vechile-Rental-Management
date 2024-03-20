
using System;

class Program
{
    static void Main(string[] args)
    {
        RentalAgency agency = new RentalAgency();

        Car car1 = new Car("Civic", "Honda", 2022, 50, 5);
        Truck truck1 = new Truck("F150", "Ford", 2020, 100, 5000);
        Motorcycle bike1 = new Motorcycle("Ninja", "Kawasaki", 2019, 30, "Sport");

        agency.AddVehicle(car1);
        agency.AddVehicle(truck1);
        agency.AddVehicle(bike1);

        agency.DisplayAllVehiclesDetails();
    }
}
