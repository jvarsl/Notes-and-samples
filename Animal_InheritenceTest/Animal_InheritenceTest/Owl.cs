using System;

namespace Animal_InheritenceTest
{
    public class Owl : Bird, IFly
    {
        public void Fly()
        {
            Console.WriteLine($"{Name}, the {nameof(Owl)} is flying.");
        }
    }

}
