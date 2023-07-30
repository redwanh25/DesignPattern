using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorator
{
    public class OfferPrice : CarDecorator
    {
        private readonly ICar car;

        public OfferPrice(ICar car) : base(car)
        {
            this.car = car;
        }

        public override double GetDiscountedPrice()
        {
            return .8 * car.GetPrice();
        }
    }
}
