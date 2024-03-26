namespace Assignment3;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Camry", "Toyota", 2015, 20.50m, 4, "V4", "Automatic", false);
        Car car2 = new Car("F150", "Ford", 2020, 40.50m, 4, "V8", "Manual", true);

        Truck truck = new Truck("Silverado", "Chevrolet", 2020, 50.50m, 1000, "Diesel", true);

        Motorcycle motorcycle = new Motorcycle("CBR", "Honda", 2022, 30.50m, 1000, "Gasoline", true);

        RentalAgency agency = new RentalAgency(10);
        agency.addVehicle(car);
        agency.addVehicle(car2);
        agency.addVehicle(truck);
        agency.addVehicle(motorcycle);

        agency.rentVehicle(car);
        motorcycle.displayDetails();
    }
}