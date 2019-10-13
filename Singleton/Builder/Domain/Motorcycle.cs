using Builder.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Domain
{
    public class Motorcycle
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ChassiSize ChassiSize { get; set; }
        public ColorType ColorType { get; set; }
        public MotorcycleType MotorcycleType { get; set; }
    }
}
