using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMethod
{
    internal class BirdAdapter : IToyDuck
    {

        IBird bird;
        public BirdAdapter(IBird bird)
        {
            this.bird = bird;
        }
        public void squeak()
        {
            bird.makeSound();
        }
    }
}


/*
     Note:- This is the adaptor class where we addept Ibard interface method to IToyBard interface.
 
 
 */
