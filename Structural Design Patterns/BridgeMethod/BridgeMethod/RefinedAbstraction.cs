using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMethod
{
    //// RefinedAbstraction class
    public class RefinedAbstraction :Abstraction
    {
        public RefinedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("RefinedAbstraction Operation");
            implementation.OperationImplementation();
        }
    }
}
