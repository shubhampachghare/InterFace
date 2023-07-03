using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
     interface IAnimal
     {
        void AnimalSound(); //does not have body
     }

     class Pig : IAnimal 
     {
        public void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
     }

}
