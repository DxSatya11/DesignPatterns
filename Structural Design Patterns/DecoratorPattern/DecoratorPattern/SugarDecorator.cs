using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{

    // Concrete decorator 2
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return $"{_coffee.GetDescription()}, Sugar";
        }

        public override double Cost()
        {
            return _coffee.Cost() + 0.2;
        }
    }
}
