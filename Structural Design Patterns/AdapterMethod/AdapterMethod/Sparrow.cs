using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMethod
{
    internal class Sparrow : IBird
    {
        public void fly()
        {
            Console.WriteLine("Flying");
        }

        public void makeSound()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
}
