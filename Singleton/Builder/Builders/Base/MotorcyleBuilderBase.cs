using Builder.Domain;
using Builder.Processors;

namespace Builder.Builders.Base
{
    public abstract class MotorcyleBuilderBase
    {
        protected Motorcycle Motorcycle = null;
        protected readonly ICalcPrice CalcPrice;

        protected MotorcyleBuilderBase(ICalcPrice calcPrice)
        {
            CalcPrice = calcPrice;
        }

        public virtual void DefinePrice()
        {
            CalcPrice.GetPrice(Motorcycle);
        }

        public Motorcycle GetMotorcycle()
        {
            return Motorcycle;
        }

        protected void Init()
        {
            Motorcycle = new Motorcycle();
        }
    }
}
