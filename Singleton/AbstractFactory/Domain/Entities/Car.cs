using AbstractFactory.Domain.Base;
using AbstractFactory.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Domain.Entities
{
    public class Car : VehicleBase
    {
        public Car(string model, int capacity) : base(model, VehiclesTypes.Car, capacity)
        {

        }
    }
}
