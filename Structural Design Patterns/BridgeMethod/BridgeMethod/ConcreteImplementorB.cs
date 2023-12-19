using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMethod
{
    // ConcreteImplementorB class
    public class ConcreteImplementorB : IImplementation
    {
        public void OperationImplementation()
        {
            Console.WriteLine("ConcreteImplementorB OperationImplementation");
        }
    }
}
