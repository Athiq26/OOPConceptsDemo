using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConceptsDemo.OOPConcepts;

namespace OOPConceptsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance Example
            Console.WriteLine("Inheritance Example:");
            Dog myDog = new Dog();
            myDog.Name = "Buddy";
            myDog.Eat();      // Calls Animal's Eat method
            myDog.Sleep();    // Calls Animal's Sleep method
            myDog.Bark();     // Calls Dog's specific Bark method

            Console.WriteLine();

            Cat myCat = new Cat();
            myCat.Name = "Whiskers";
            myCat.Eat();      // Calls Animal's Eat method
            myCat.Sleep();    // Calls Animal's Sleep method
            myCat.Meow();     // Calls Cat's specific Meow method

            Console.WriteLine();

            // Polymorphism Example
            Console.WriteLine("Polymorphism Example:");
            Shape shape;

            shape = new Circle();
            shape.Draw(); // Calls Circle's Draw method

            shape = new Rectangle();
            shape.Draw(); // Calls Rectangle's Draw method

            Console.WriteLine();

            Calculator calculator = new Calculator();
            Console.WriteLine("Integer Addition: " + calculator.Add(5, 10));
            Console.WriteLine("Double Addition: " + calculator.Add(5.5, 10.2));
            Console.WriteLine("String Concatenation: " + calculator.Add("Hello", " World"));

            Console.WriteLine();

            // Encapsulation Example
            Console.WriteLine("Encapsulation Example:");
            Encapsulation person = new Encapsulation();
            person.Name = "Alice";
            person.Age = 30;
            person.DisplayInfo(); // Displays Name and Age

            Console.WriteLine();

            // Abstraction Example
            Console.WriteLine("Abstraction Example:");
            Vehicle myCar = new Car();
            myCar.Brand = "Toyota";
            myCar.DisplayBrand(); // Displays brand
            myCar.Drive();        // Calls Car's Drive method

            Console.WriteLine();

            Vehicle myBike = new Bike();
            myBike.Brand = "Yamaha";
            myBike.DisplayBrand(); // Displays brand
            myBike.Drive();        // Calls Bike's Drive method
        }
    }
}
   
