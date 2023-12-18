using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WebDeveloper : Employee
    {
        public string name()
        {
            return "A Web developer";
        }

        public int salary()
        {
            return 200;
        }
    }
}
