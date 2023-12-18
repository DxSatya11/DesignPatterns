using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AndroidDeveloper : Employee
    {
        public string name()
        {
            return "An android developer";
        }

        public int salary()
        {
            return 500;
        }
    }
}
