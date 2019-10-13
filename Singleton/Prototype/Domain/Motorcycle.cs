using System;

namespace Prototype.Domain
{
    public sealed class Motorcycle
    {
        public string Company { get; set; }
        public string Year { get; set; }
        public string Model { get; set; }

        public Motorcycle ShallowCopy()
        {
            return (Motorcycle)MemberwiseClone();
        }
        public Motorcycle DeepClone()
        {
            return new Motorcycle
            {
                Company = string.Copy(Company),
                Year = string.Copy(Year),
                Model = string.Copy(Model)
            };
        }
    }
}
