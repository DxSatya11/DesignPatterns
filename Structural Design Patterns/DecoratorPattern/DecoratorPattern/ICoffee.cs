using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // Component interface
    public interface ICoffee
    {
        string GetDescription();
        double Cost();
    }
}
