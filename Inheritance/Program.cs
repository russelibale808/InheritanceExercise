using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var Birds = new Birds();

            Birds.CanFly = true;
            Birds.HasBeak = true;
            Birds.LaysEggs = true;
            Birds.HasFeathers = true;

            Birds.HasFourLegs = false;
            Birds.DrinksWater = true;
            Birds.IsFriendly = true;
            Birds.Sound = "KahhhKAHHHH";

            Birds.BirdStats();

            Console.WriteLine();






            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var Reptiles = new Reptile();

            Reptiles.ColdBlooded = true;
            Reptiles.HasBackBones = true;
            Reptiles.HasScales = true;
            Reptiles.BreathThroughLungs = true;

            Reptiles.DrinksWater = true;
            Reptiles.HasFourLegs = true;
            Reptiles.IsFriendly = false;
            Reptiles.Sound = "SSSSSsssssssSSSSS";

            Reptiles.RepStats();
        }
    }
}
