using PrototypeDesignPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        NetworkConnection networkConnection =  new NetworkConnection();
        networkConnection.setIp("127.0.0.1");
        networkConnection.loadimportantData();

        Console.WriteLine(networkConnection);

        //Here we want a new object of network connection but here we are not creating new object we just copy the existing object data here
        NetworkConnection networkConnection2 = (NetworkConnection)networkConnection.Clone();  
        Console.WriteLine(networkConnection2);

    }
}


/*
 
       -->NOTE:-
          *We use ProtoType design pattern to copy an existinh object rather than creating new instance from screatch because creating new object everytime may be no an good idea.
          *So if we use Prototype design parten it save memory and time.



*/