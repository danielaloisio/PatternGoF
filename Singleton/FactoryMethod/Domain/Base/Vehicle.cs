using FactoryMethod.Domain.ValueObj;

namespace FactoryMethod.Domain.Base
{
    public abstract class Vehicle
    {
        public int TopSpeed { get; set; }

        public int Capacity { get; set; }

        public double Price { get; set; }

        public VehicleType VehicleType { get; set; }
    }
}
