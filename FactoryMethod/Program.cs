using FactoryMethod;

Console.WriteLine("Factory Method Design Pattern (Creational Design Pattern)");

var carFactory = new CarFactory();
var truckFactory = new TruckFactory();

Client(carFactory);
Client(truckFactory);

void Client(IVehicleFactory vehicleFactory)
{
    IVehicle vehicle = vehicleFactory.CreateVehicle();
    vehicle.Drive();
}

