using SingletonDesignParten;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args) 
    {

        // // Directly creating object of Employee Class will give error because we were using Private  Constroctor.

        //new Employee();

        ////Employee with Lazy way

        //Employee employee1 = Employee.getEmployee();
        //Console.WriteLine(employee1.GetHashCode());

        //Employee employee2 = Employee.getEmployee();
        //Console.WriteLine(employee2.GetHashCode());

        ////Console.ReadLine();




        ////Student with Early  way
        //Student student1 = Student.getStudent();
        //Console.WriteLine(student1.GetHashCode());

        //Student student2 = Student.getStudent();
        //Console.WriteLine(student2.GetHashCode());

        //Console.ReadLine();



        // Break singleton design parten using Reflection API
        Employee employee = Employee.getEmployee();
        Console.WriteLine(employee.GetHashCode());



        //For Enum
        //Employee employee = Employee.Instance;
        //Console.WriteLine(employee.GetHashCode());



        // Get the Type of the Employee class
        Type employeeType = typeof(Employee);

        // Get the private constructor
        ConstructorInfo privateConstructor = employeeType.GetConstructor(
            BindingFlags.Instance | BindingFlags.NonPublic,
            null,
            Type.EmptyTypes,
            null
        );

        // Create an instance using the private constructor
        Employee employees = (Employee)privateConstructor.Invoke(null);

        // Use the instance
        Console.WriteLine(employees.GetHashCode());




        ////Type employeeType = typeof(Employee);

        ////// Get the private constructor
        ////ConstructorInfo privateConstructor = employeeType.GetConstructor(
        ////    BindingFlags.Instance | BindingFlags.NonPublic,
        ////    null,
        ////    Type.EmptyTypes,
        ////    null
        ////);

        ////// Get the MethodAttributes and make the constructor public
        ////MethodInfo methodInfo = privateConstructor.GetType().GetMethod("SetMethodAttributes", BindingFlags.Instance | BindingFlags.NonPublic);
        ////methodInfo.Invoke(privateConstructor, new object[] { MethodAttributes.Public });

        ////// Create an instance using the private constructor
        ////Employee employees = (Employee)privateConstructor.Invoke(null);

        ////// Use the instance
        ////Console.WriteLine(employees.GetHashCode());







    }
}



/*
   
     POINTS TO REMEMBER:-

     ->Problem in Eager way
        1. Static initalization will happend first so the object of the class will be create even 
          if we dont't use the object in our application.




    ->Problem in Lazy way
        1. It will create object only when method will call it is good but it will be problem in case of 
           "Multithreading". Becaue if there is multiple thread executing simultaniously then 
           that objct wll be creat multiple time which does't obay Singleton esign Parten

       2.For Threat safety we can use synchronized way. In Synchronized way also there are problem 
         if there is lot of lines of code inside the method. To solve this problem we should use 
         Synchronized block instant of Synchronized Method.




     #Note:-  
           
           -> We can break singleton design parten by using Reflection API
     
*/




/*
   
     #Note:-  
           *How to break singleton design parten
           
              -> We can break singleton design parten by using Reflection API.
              ->To solve this we can do if there is already object then we can throw exception
                or we can use Enum to fix it.
     
*/