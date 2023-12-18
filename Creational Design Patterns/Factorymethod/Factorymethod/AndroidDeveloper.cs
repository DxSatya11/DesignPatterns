using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorymethod
{
    public class AndroidDeveloper : Employee
    {
        public int salary()
        {
            Console.Write("Salary:");
            return 100;
        }
    }
}
