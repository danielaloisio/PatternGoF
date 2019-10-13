using Builder.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Processors
{
    public class CalcPrice : ICalcPrice
    {
        public void GetPrice(Motorcycle motorcycle)
        {
            motorcycle.Price = 50;
        }
    }
}
