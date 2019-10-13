using AbstractFactory.Domain.Interface;
using AbstractFactory.Domain.ValueObj;

namespace AbstractFactory.Domain.Base
{
    public abstract class VehicleBase : IVehicle
    {
        public VehiclesTypes VehiclesTypes { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }

        public VehicleBase(string model, VehiclesTypes vehiclesTypes, int capacity)
        {
            Model = model;
            VehiclesTypes = vehiclesTypes;
            Capacity = capacity;
        }

        public int GetCapacity() => Capacity;
    }
}
