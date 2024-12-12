using System;

namespace OOPConceptsDemo.OOPConcepts
{
    internal class Encapsulation
    {
        // Private fields
        private string _name;
        private int _age;

        // Public properties for controlled access
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else
                    throw new ArgumentException("Name cannot be empty.");
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                    _age = value;
                else
                    throw new ArgumentException("Age must be positive.");
            }
        }

        // Method to display information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}");
        }
    }
}
