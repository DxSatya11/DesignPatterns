using AbstractFactory;

internal class Program
{
    private static void Main(string[] args)
    {
        //For AndriodDeveloper
         Employee andriod = EmployeeFactory.getEmployee(new AndriodDeveloperFActory());
         Console.WriteLine($"{andriod.name()} with salary {andriod.salary()}");


        //For WebDeveloper
        //Employee web = EmployeeFactory.getEmployee(new WebDeveloperFActory());
        //Console.WriteLine($"{web.name()} with salary {web.salary()}");
    }
}


/*
    -->  Abstract factory patetrn is similar to Factory parten and it considered as another layer of Factory pattern for abstraction perpose.

    #To achive Abstract patter we added more abstract layer to Factory parten so that our Factory class will be depend upon another abstract class to creat object. so that the manin factory 
     class also don't have idea for which class it will creat the object
  
  
  
  
 */