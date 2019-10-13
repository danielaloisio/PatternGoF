using Prototype.Domain;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var motorcycleOne = new Motorcycle{ Company = "Harley Davidson", Model = "Fat Bob", Year = "2008" };

            var motorcycleTwo = motorcycleOne.DeepClone();
            motorcycleTwo.Company = "Honda";

            Console.WriteLine($"{motorcycleTwo.Company}");
        }
    }
}
