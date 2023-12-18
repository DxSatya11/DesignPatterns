using AdapterMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Adapters design Patterns");

        Sparrow sparrow = new Sparrow();
        IToyDuck toyDuck = new PlasticToyDuck();


        IToyDuck birdAdapter = new BirdAdapter(sparrow);
        Console.WriteLine("Sparrow...");
        sparrow.fly();
        sparrow.makeSound();

        Console.WriteLine("ToyDuck...");
        toyDuck.squeak();

        Console.WriteLine("BirdAdapter...");
        birdAdapter.squeak();



    }
}


/*
 
     Mote:- In design, adapters are used when we have a class (Client) expecting some type of object and we have an object (Adaptee) 
            offering the same features but exposing a different interface.

    To use an adapter:

     -->The client makes a request to the adapter by calling a method on it using the target interface.
     -->The adapter translates that request on the adaptee using the adaptee interface.
     -->Client receive the results of the call and is unaware of adapter’s presence.

   ** -->The adapter pattern convert the interface of a class into another interface clients expect. 
         Adapter lets classes work together that couldn’t otherwise because of incompatible interfaces



      The adapter pattern we have implemented above is called Object Adapter Pattern because the adapter holds an instance of adaptee. 
        There is also another type called Class Adapter Pattern which use inheritance instead of composition but you require multiple inheritance to implement it
 
  
 */