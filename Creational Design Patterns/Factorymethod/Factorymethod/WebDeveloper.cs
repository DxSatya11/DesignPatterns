using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorymethod
{
    public class WebDeveloper : Employee
    {
        public int salary()
        {
            Console.Write("Web develioper Salary:");
            return 50;
        }
    }
}
