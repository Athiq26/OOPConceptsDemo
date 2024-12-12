using System;

namespace OOPConceptsDemo.OOPConcepts
{
    // Abstract base class
    internal abstract class Vehicle
    {
        public string Brand { get; set; }

        // Abstract method (must be implemented in derived classes)
        public abstract void Drive();

        // Non-abstract method (can have common functionality)
        public void DisplayBrand()
        {
            Console.WriteLine($"Vehicle Brand: {Brand}");
        }
    }

    // Derived class 1
    internal class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }

    // Derived class 2
    internal class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Riding a bike.");
        }
    }
}
