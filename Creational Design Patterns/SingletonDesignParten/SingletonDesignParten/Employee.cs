using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignParten
{
    public class Employee
    {
        //private filed to store the object
        private static Employee? employee;

        //use for thread safe 
        private static readonly object lockObject = new object();

        //private constructor so we can't create it's object directly
        private Employee()
        {
            //if (employee != null)
            //{
            //    // Console.WriteLine("You are trying to break Singleton parten");
            //    throw new InvalidOperationException("Singleton pattern violation: An instance of Employee already exists.");
            //}
        }



        //Not Synchronized
        //Lazy way of creating singleton desig parten
        //public static Employee getEmployee()
        //{

        //    //Condition to create object of Employee Class single time
        //    if(employee == null)
        //    {
        //        employee = new Employee();  
        //    }
        //    return employee;
        //}



        //Synchronized way with threadsafe
        // Synchronized block
        public static Employee getEmployee()
        {

            if (employee == null)
            {
                lock (lockObject)
                {
                    if (employee == null)
                    {
                        employee = new Employee();
                    }
                }
            }

            return employee;
        }


    }







    ////Use Enum to break singleton pattern
    //public enum Employee
    //{

    //    Instance

    //}
}

/*
   
     POINTS TO REMEMBER:-

     -> Private constructor so we can't create it's object
     -> Create object of the class only single time to achive Singleton design aparten.
     -> Create object of the class by using the method.
     -> Create one private filed to store the object.
*/
