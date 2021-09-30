using System;
//https://v1study.com/csharp-practical-3-a618.html
namespace v1study_ZooManagmentTask
{
    public class Tiger : Animal
    {
        public Tiger()
        {
        }

        public Tiger(string name) : base(name)
        {
        }

        public Tiger(string name, DateTime dateOfBirth) : base(name, dateOfBirth)
        {
        }

        public Tiger(string name, DateTime dateOfBirth, string description) : base(name, dateOfBirth, description)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Roar!");
        }
    }
}
