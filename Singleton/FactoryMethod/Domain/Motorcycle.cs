using FactoryMethod.Domain.Base;
using FactoryMethod.Domain.ValueObj;

namespace FactoryMethod.Domain
{
    public sealed class Motorcycle : Vehicle
    { 
        public Motorcycle() : base()
        {
            TopSpeed = 130;
            VehicleType = VehicleType.Motorcycle;
            Capacity = 2;
            Price = 20;
        }
    }
}
