using DecoratorPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Decorator Pattern");

        // Creating a simple coffee
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"Description: {coffee.GetDescription()}, Cost: ${coffee.Cost()}");

        // Decorating the coffee with milk
        ICoffee milkCoffee = new MilkDecorator(coffee);
        Console.WriteLine($"Description: {milkCoffee.GetDescription()}, Cost: ${milkCoffee.Cost()}");

        // Decorating the coffee with sugar
        ICoffee sugarMilkCoffee = new SugarDecorator(milkCoffee);
        Console.WriteLine($"Description: {sugarMilkCoffee.GetDescription()}, Cost: ${sugarMilkCoffee.Cost()}");
    }
}


/*
        -->The Decorator Pattern is a structural design pattern that allows behavior to be added to an individual object, either statically or dynamically, 
            Without affecting the behavior of other objects from the same class.
  
  
  

     EXAMPLE:-
     
        Suppose we are building an application for a pizza store and we need to model their pizza classes. Assume they offer four types of pizzas namely Peppy Paneer, Farmhouse, Margherita  and Chicken Fiesta. 
        Initially we just use inheritance and abstract out the common functionality in a Pizza class.

         
        Each pizza has different cost. We have overridden the getCost() in the subclasses to find the appropriate cost. Now suppose a new requirement, in addition to a pizza, customer can also ask for several toppings such as Fresh Tomato, Paneer, Jalapeno, Capsicum, Barbeque, etc. Let us think about for sometime that how do we accommodate changes in the above classes so that customer can choose pizza with toppings and we get the total cost of pizza and toppings the customer chooses. 
        Let us look at various options. Option 1 Create a new subclass for every topping with a pizza
  
        This looks very complex. There are way too many classes and is a maintenance nightmare. Also if we want to add a new topping or pizza we have to add so many classes

        Let’s add instance variables to pizza base class to represent whether or not each pizza has a topping The getCost() of superclass calculates the costs for all the toppings while the one in the subclass adds the cost of that specific pizza.



        IN MY CODE:-
          
         ICoffee is the component interface representing a basic coffee.
         SimpleCoffee is a concrete component implementing ICoffee.
         CoffeeDecorator is an abstract decorator class that implements ICoffee and holds a reference to another ICoffee instance.
         MilkDecorator and SugarDecorator are concrete decorators that add milk and sugar, respectively, to the coffee.

 */