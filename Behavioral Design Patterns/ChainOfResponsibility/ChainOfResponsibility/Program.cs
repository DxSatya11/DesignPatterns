using ChainOfResponsibility;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Chain of Responsibility Design Pattern!");

        // Create the chain of handlers
        IHandler handler1 = new ConcreteHandler1();
        IHandler handler2 = new ConcreteHandler2();

        handler1.NextHandler = handler2;

        // Make requests
        handler1.HandleRequest(5);
        handler1.HandleRequest(15);
        handler1.HandleRequest(25);
    }
}

/*
        --> In ChainOf Responsibility   a request from the client is passed to a chain of objects to process them. Later, the object in the chain will decide themselves who will be processing- 
            the request and whether the request is required to be sent to the next object in the chain or not.

        -->This pattern is recommended when multiple objects can handle a request and the handler doesn’t have to be a specific object. Also, the handler is determined at runtime.
           Please note that a request not handled at all by any handler is a valid use case.
  
  
       -->Handler : This can be an interface which will primarily receive the request and dispatches the request to a chain of handlers. 
                 It has reference to the only first handler in the chain and does not know anything about the rest of the handlers.

       -->Concrete handlers : These are actual handlers of the request chained in some sequential order.

       -->Client : Originator of request and this will access the handler to handle it.
  
 
           


                                                                     **In My Example**
                     
         In this example, IHandler is the interface that defines the handler's contract. ConcreteHandler1 and ConcreteHandler2 are two concrete handlers that implement the IHandler interface. 
         The client code creates a chain by setting the NextHandler property for each handler.

         When a request is made, it is passed through the chain of handlers. Each handler decides whether to process the request or pass it to the next handler. 
         This way, you can easily add or remove handlers without modifying the client code.
 */