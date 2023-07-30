using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public abstract class CarDecorator : ICar
    {
        private readonly ICar car;

        protected CarDecorator(ICar car)
        {
            this.car = car;
        }

        public string Make { get { return car.Make; } }

        public double GetPrice()
        {
            return car.GetPrice();
        }

        public abstract double GetDiscountedPrice();
    }
}
