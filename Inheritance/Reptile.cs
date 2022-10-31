using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

        }

        public bool ColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public bool HasBackBones { get; set; }
        public bool BreathThroughLungs { get; set; }

        public void RepStats()
        {
            Console.WriteLine("Reptiles are cold blooded, has scales, has backbones and breath through their lungs");
            Console.WriteLine($"The sound a reptile makes for example a Aligator, their sounds makes a {Sound} noise");
        }
    }

}
