using FactoryMethod.Domain.Base;
using FactoryMethod.Domain.ValueObj;

namespace FactoryMethod.Domain
{
    public sealed class Car : Vehicle
    { 
        public Car() : base()
        {
            TopSpeed = 180;
            VehicleType = VehicleType.Car;
            Capacity = 5;
            Price = 55;
        } 
    }
}
