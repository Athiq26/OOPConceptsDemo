using System;

namespace OOPConceptsDemo.OOPConcepts
{
    // Base class
    internal class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }

    // Derived class
    internal class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} says: Woof! Woof!");
        }
    }

    // Another derived class
    internal class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }
}
