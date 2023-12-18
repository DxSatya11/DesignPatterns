using Factorymethod;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        //// We can do like this but it will make tightly coupled so used factory parten
        // Employee employee = new AndroidDeveloper(); 




        //Based on the input paramenter it will create object of the class  which followed factory parten

        string emp = "Web Developer";

        Employee employee = EmployeeFactory.getEmployee(emp);
        int salary = employee.salary();
        Console.WriteLine(salary);
    }
}




/*
    What is Factory method:-

     When there is Superclass and multiple subclasses and we want to create object of subclass based on the input and requirment.
     Then we use factory class which take responsibility to create objet of class based on input.

   Advantages of Factory MEthod:-

      1:- Focus on creating object for interface rather than implementation.
      2:- Loos coupling, moere robust code.
 
 */