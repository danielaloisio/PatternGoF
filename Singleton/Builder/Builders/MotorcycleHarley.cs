using Builder.Builders.Base;
using Builder.Domain.ValueObject;
using Builder.Processors;

namespace Builder.Builders
{
    public sealed class MotorcycleHarley : MotorcyleBuilderBase, IMotorcycleBuilder
    {
        public MotorcycleHarley(ICalcPrice calcPrice) : base(calcPrice)
        {

        }

        public void PrepareMotorcycle(ChassiSize chassiSize, ColorType colorType, MotorcycleType motorcycleType, string name)
        {
            this.Init();

            this.Motorcycle.ChassiSize = chassiSize;
            this.Motorcycle.MotorcycleType = motorcycleType;
            this.Motorcycle.ColorType = colorType;
            this.Motorcycle.Name = name;
        }
    }
}
