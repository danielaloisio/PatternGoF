using Builder.Builders;
using Builder.Builders.Base;
using Builder.Director;
using Builder.Domain.ValueObject;
using Builder.Processors;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var getPRice = new CalcPrice();

            IMotorcycleBuilder motorcycleBuilder = new MotorcycleHarley(getPRice);

            var motorcycleService = new MotorcycleService();

            motorcycleService.PrepareMotorcycleHarley(motorcycleBuilder, ChassiSize.Large, ColorType.Black, MotorcycleType.Softail, "Fat bob");
               
            var harley = motorcycleBuilder.GetMotorcycle();

            Console.WriteLine($"{harley.Name} - {harley.Price} - {harley.ColorType.ToString() }, {harley.MotorcycleType.ToString()}");
        }
    }
}
