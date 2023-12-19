using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMethod
{
    // Abstraction class
    public abstract class Abstraction
    {
        protected IImplementation implementation;

        protected Abstraction(IImplementation implementation)
        {
            this.implementation = implementation;
        }

        public abstract void Operation();
    }
}
