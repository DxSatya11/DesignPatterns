using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // Concrete component
    public class SimpleCoffee : ICoffee
    {
        public double Cost()
        {
            return 2.0;
        }

        public string GetDescription()
        {
            return "Simple Coffee";
        }
    }
}
