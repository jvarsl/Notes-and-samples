using System;
//https://v1study.com/csharp-practical-3-a618.html
namespace v1study_ZooManagmentTask
{
    public class Cat : Animal
    {
        public Cat()
        {
        }

        public Cat(string name) : base(name)
        {
        }

        public Cat(string name, DateTime dateOfBirth) : base(name, dateOfBirth)
        {
        }

        public Cat(string name, DateTime dateOfBirth, string description) : base(name, dateOfBirth, description)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
}
