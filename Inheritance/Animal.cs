using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {
        }

        public bool DrinksWater { get; set; }
        public bool IsFriendly { get; set; }
        public bool HasFourLegs { get; set; }
        public string Sound { get; set; }

        public void AnimalSats()
        {
            
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Sound}");
        }
    }
}
