using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class EmployeeFactory
    {
        //get employee method but this abstract have no idea for which class they are creating object
        public static Employee getEmployee(EmployeeAbstractFactory employeeAbstractFactory) 
        {
            return employeeAbstractFactory.creatEmployee();
        }
    }
}
