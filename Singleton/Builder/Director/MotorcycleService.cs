using Builder.Builders.Base;
using Builder.Domain.ValueObject;

namespace Builder.Director
{
    public class MotorcycleService
    {
        public void PrepareMotorcycleHarley(IMotorcycleBuilder motorcycleBuilder, ChassiSize chassiSize, ColorType colorType, MotorcycleType motorcycleType, string name)
        {
            motorcycleBuilder.PrepareMotorcycle(chassiSize, colorType, motorcycleType, name);
            motorcycleBuilder.DefinePrice();
        }
    }
}
