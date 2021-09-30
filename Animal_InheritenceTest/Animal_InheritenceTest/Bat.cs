using System;

namespace Animal_InheritenceTest
{
    public class Bat : Mammal, IFly
    {
        public void Fly()
        {
            Console.WriteLine($"The {nameof(Bat)}-man is flying!");
        }
    }

}
