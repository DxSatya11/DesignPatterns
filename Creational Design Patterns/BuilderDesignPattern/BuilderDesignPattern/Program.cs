using BuilderDesignPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

       User user =  new User.UserBuilder().setuserName("XYZ").setUserId("KLL").setEmaliID("vbfdv@gmail.com").Build();

       Console.WriteLine(user);
    }
}



/*
       -->Builder design parten we used to overcome from Factory design parten issues
 
 


 
 */