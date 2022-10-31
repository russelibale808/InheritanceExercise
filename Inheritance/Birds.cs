using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Birds : Animal
    {
        public Birds()
        {

        }

        public bool CanFly { get; set; }
        public bool HasFeathers { get; set; }
        public bool HasBeak { get; set; }
        public bool LaysEggs { get; set; }

        public void BirdStats()
        {
            Console.WriteLine("Birds can fly, has feathers, has a beak, and lays eggs");
            Console.WriteLine($"They are friendly, drinks water, doesn't have 4 legs and makes a {Sound} sound");
        }
    }


}
