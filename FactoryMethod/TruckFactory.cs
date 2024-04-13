namespace FactoryMethod
{
    public class TruckFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }
}
