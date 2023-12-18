using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //We created this class to implement our EmployeeAbstractFactory class for creating object
    public class WebDeveloperFActory : EmployeeAbstractFactory
    {
        public override Employee creatEmployee()
        {
            return new WebDeveloper();   
        }
    }
}
