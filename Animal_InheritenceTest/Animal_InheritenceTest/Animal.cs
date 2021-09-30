using System;

namespace Animal_InheritenceTest
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} has started eating.");
        }
    }

}
