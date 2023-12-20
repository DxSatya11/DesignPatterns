using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // Concrete decorator 1
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }
        public override string GetDescription()
        {
            return $"{_coffee.GetDescription()}, Milk";
        }

        public override double Cost()
        {
            return _coffee.Cost() + 0.5;
        }
    }
}
