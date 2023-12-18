using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorymethod
{

    //This is the important class which has factory methods which will return object of employee class based on input
    public class EmployeeFactory
    {
        ////get the employee
        public static Employee getEmployee(string empType)
        {
            if(empType == "Android Developer") 
            {
                return new AndroidDeveloper();
            }
            else if(empType == "Web Developer")
            {
                return new WebDeveloper();
            }
            else
            {
                return null;
            }
        }
    }
}
