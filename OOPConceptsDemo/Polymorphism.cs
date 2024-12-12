using System;

namespace OOPConceptsDemo.OOPConcepts
{
    // Base class
    internal class Shape
    {
        // Virtual method to allow overriding
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape.");
        }
    }

    // Derived class 1
    internal class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    // Derived class 2
    internal class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }

    // Demonstrating compile-time polymorphism (method overloading)
    internal class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public string Add(string a, string b)
        {
            return a + b;
        }
    }
}
