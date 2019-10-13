using AbstractFactory.Domain.Base;
using AbstractFactory.Domain.ValueObj;
using AbstractFactory.Factory.AbstractFactory;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var carFactory = VehicleAbstractFactory.CreateFactory(VehiclesTypes.Car);
            var motorcycleFactory = VehicleAbstractFactory.CreateFactory(VehiclesTypes.Motorcycle);

            var carOne = carFactory.CreateVehicle("Uno", 5);
            var motorcycleOne = motorcycleFactory.CreateVehicle("Harley", 2);

            Print(carOne);
            Print(motorcycleOne);
        }

        public static void Print(VehicleBase vehicleBase)
        {
            Console.WriteLine($"Modelo: { vehicleBase.Model } - Capacidade: { vehicleBase.GetCapacity() } - Tipo: { vehicleBase.VehiclesTypes.ToString() }");
        }
    }
}
