using AbstractFactory.Domain.Base;
using AbstractFactory.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Domain.Entities
{
    public class Motorcycle : VehicleBase
    {
        public Motorcycle(string model, int capacity) : base(model, VehiclesTypes.Motorcycle, capacity)
        {

        }
    }
}
