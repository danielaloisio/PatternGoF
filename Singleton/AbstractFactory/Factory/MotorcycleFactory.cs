using AbstractFactory.Domain.Base;
using AbstractFactory.Domain.Entities;
using AbstractFactory.Factory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public sealed class MotorcycleFactory : VehicleAbstractFactory
    {
        public override VehicleBase CreateVehicle(string model, int capacity)
        {
            return new Motorcycle(model, capacity);
        }
    }
}
