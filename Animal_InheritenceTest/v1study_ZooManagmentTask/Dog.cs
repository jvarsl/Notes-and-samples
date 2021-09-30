using System;
//https://v1study.com/csharp-practical-3-a618.html
namespace v1study_ZooManagmentTask
{
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Bark bark");
        }
        public Dog(string name) : base(name)
        {
        }

        public Dog(string name, DateTime dateOfBirth) : base(name, dateOfBirth)
        {
        }

        public Dog(string name, DateTime dateOfBirth, string description) : base(name, dateOfBirth, description)
        {
        }

        public Dog()
        {
        }
    }
}
