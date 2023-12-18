using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    //Our main factory(EmployFactory)  class depend upon this abstract class
    public abstract class EmployeeAbstractFactory
    {
        public abstract Employee creatEmployee();
    }
}
