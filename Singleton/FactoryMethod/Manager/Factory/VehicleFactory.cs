using FactoryMethod.Domain;
using FactoryMethod.Domain.Base;
using FactoryMethod.Domain.ValueObj;

namespace FactoryMethod.Manager.Factory
{
    public class VehicleFactory
    {
        public Vehicle GetVehicle(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Car: return new Car();

                case VehicleType.Motorcycle: return new Motorcycle();

                default: return new Car();

            }

        }
    }
}
