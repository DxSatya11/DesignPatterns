internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Composite method");

        // Create a file system structure
        CompositeMethod.Directory root = new CompositeMethod.Directory("Root");

        CompositeMethod.File file1 = new CompositeMethod.File("Document.txt", 100);
        CompositeMethod.File file2 = new CompositeMethod.File("Image.jpg", 200);

        root.AddItem(file1);
        root.AddItem(file2);

        CompositeMethod.Directory subDirectory = new CompositeMethod.Directory("SubDirectory");
        CompositeMethod.File file3 = new CompositeMethod.File("Code.cs", 150);

        subDirectory.AddItem(file3);
        root.AddItem(subDirectory);

        // Calculate and display the total size of the file system
        int totalSize = root.GetSize();
        Console.WriteLine($"Total Size of the File System: {totalSize} bytes");


    }
}

/*               
             
                POINT:- If you are not aware about tree then first gone through it then try to understand Composite Design patterns.
 
 
     --> Composite pattern is a partitioning design pattern and describes a group of objects that is treated the same way as a single instance of the same type of object.

     -->It allows clients to treat individual objects and compositions of objects uniformly. In simpler terms, it lets you build complex structures from simple ones.
  
     -->Compose objects into tree structure to represent part-whole hierarchies. Composite lets client treat individual objects and compositions of objects uniformly.
    
     -->When dealing with Tree-structured data, programmers often have to discriminate between a leaft-node and a branch. This makes code more complex, and therefore, error prone. 
        The solution is an interface that allows treating complex and primitive objects uniformly.



     The Composite Pattern has four participants:

      #- Component – Component declares the interface for objects in the composition and for accessing and managing its child components. It also implements default behavior for the interface common to all classes as appropriate.

      #- Leaf – Leaf defines behavior for primitive objects in the composition. It represents leaf objects in the composition.

      #- Composite – Composite stores child components and implements child related operations in the component interface.

      #- Client – Client manipulates the objects in the composition through the component interface.


  -->Client use the component class interface to interact with objects in the composition structure. If recipient is a leaf then request is handled directly. If recipient is a composite, then it usually forwards request to its child components, possibly performing additional operations before and after forwarding.
  

   EXAMPLE:-
   
    In an organization, It have general managers and under general managers, there can be managers and under managers there can be developers. Now you can set a tree structure and ask each node to perform common operation like getSalary().
  

    Composite

    – Composite means it can have other objects below it. 2)

    leaf

    – leaf means it has no objects below it.



  
 */