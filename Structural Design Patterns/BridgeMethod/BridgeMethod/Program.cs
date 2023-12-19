using BridgeMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bridge design pattern");

        // Creating instances of implementors
        IImplementation implementorA = new ConcreteImplementorA();
        IImplementation implementorB = new ConcreteImplementorB();

        // Creating instances of refined abstractions with different implementors
        Abstraction abstractionA = new RefinedAbstraction(implementorA);
        Abstraction abstractionB = new RefinedAbstraction(implementorB);

        // Calling operations on refined abstractions
        abstractionA.Operation();
        abstractionB.Operation();
    }
}


/*
  
    --> The Bridge design pattern allows you separate the abstraction from the implementation 
    
    ##-> There is two part needed to implement Bridge design patterns
         1-> Abstraction
         2-> Implementation
  
 NOTE--> 

    ->The bridge pattern allows the Abstraction and the Implementation to be developed independently and 
      the client code can access only the Abstraction part without being concerned about the Implementation part.

    ->The abstraction is an interface or abstract class and the implementer is also an interface or abstract class
 
    -> It increases the loose coupling between class abstraction and it’s implementation.
  
 
 */