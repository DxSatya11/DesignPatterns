using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMethod
{
    // ConcreteImplementorA class
    public class ConcreteImplementorA : IImplementation
    {
        public void OperationImplementation()
        {
            Console.WriteLine("ConcreteImplementorA OperationImplementation");
        }
    }
}
