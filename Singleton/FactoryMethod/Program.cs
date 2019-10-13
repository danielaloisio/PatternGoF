using FactoryMethod.Domain.Base;
using FactoryMethod.Domain.ValueObj;
using FactoryMethod.Manager.Factory;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleFactory = new VehicleFactory();

            var car = vehicleFactory.GetVehicle(VehicleType.Car);
            var motorcycle = vehicleFactory.GetVehicle(VehicleType.Motorcycle);

            Console.WriteLine($"{car.VehicleType.ToString()} - {car.Capacity} - {car.TopSpeed} - {car.Price}");
            Console.WriteLine($"{motorcycle.VehicleType.ToString()} - {motorcycle.Capacity} - {motorcycle.TopSpeed} - {motorcycle.Price}");
        }
    }
}
