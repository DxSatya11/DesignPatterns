using ObserverMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Observer Pattern!");

        // Create subject
        var newsAgency = new NewsAgency();

        // Create observers
        var cnn = new NewsChannel("CNN");
        var bbc = new NewsChannel("BBC");

        // Register observers
        newsAgency.RegisterObserver(cnn);
        newsAgency.RegisterObserver(bbc);

        // Set news, observers will be notified
        newsAgency.SetNews("Breaking news: Observer Pattern example in C#");


        Console.WriteLine("After Removing bbc as a observer");
        newsAgency.RemoveObserver(bbc);
        newsAgency.SetNews("Breaking news: Observer Pattern example in C#");

        // Output:
        // CNN received news: Breaking news: Observer Pattern example in C#
        // BBC received news: Breaking news: Observer Pattern example in C#
    }
}


/*
         --> In Observer  pattern when subject changes the state all it's dependent object got to know about the changes 
         --> One to Many relationship

         --> This pattern is commonly used to implement distributed event handling systems. In C#, you can implement the Observer Pattern using delegates and events
  
  
 */