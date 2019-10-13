using Builder.Domain;
using Builder.Domain.ValueObject;

namespace Builder.Builders.Base
{
    public interface IMotorcycleBuilder
    {
        void PrepareMotorcycle(ChassiSize chassiSize, ColorType colorType, MotorcycleType motorcycleType, string name);

        void DefinePrice();

        Motorcycle GetMotorcycle();
    }
}
