using AbstractFactory.Domain.Base;
using AbstractFactory.Domain.ValueObj;
using System;

namespace AbstractFactory.Factory.AbstractFactory
{
    public abstract class VehicleAbstractFactory
    {
        public abstract VehicleBase CreateVehicle(string model, int capacity);
        public static VehicleAbstractFactory CreateFactory(VehiclesTypes vehiclesTypes)
        {
            switch (vehiclesTypes)
            {
                case VehiclesTypes.Car: return new CarFactory();

                case VehiclesTypes.Motorcycle: return new MotorcycleFactory();

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
