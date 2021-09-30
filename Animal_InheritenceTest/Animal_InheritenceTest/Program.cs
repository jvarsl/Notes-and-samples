using System;
using System.Collections.Generic;

namespace Animal_InheritenceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var zooAnimals = new List<ZooAnimal>();

            var Owlie = new Owl() { Name = "Owlie", DateOfBirth = DateTime.Parse("2010-01-01"), Feather = (FeatherType)1 };
            Owlie.Fly();
            Owlie.Eat();

            var Batman = new Bat() { Name = "Wayne", DateOfBirth = DateTime.Parse("2010-01-01") };
            Batman.Fly();
            Batman.Eat();
            Console.WriteLine("-------");

            zooAnimals.Add(new ZooAnimal(Owlie));
            zooAnimals.Add(new ZooAnimal(Batman, "Upper State"));

            foreach (var zoo in zooAnimals)
            {
                Console.WriteLine(zoo.Location);
                if(zoo.Animal is Bird b)
                {
                    Console.WriteLine(b.Feather);
                }
                if(zoo.Animal is IFly fly)
                {
                    fly.Fly();
                }
            }
        }

    }

}
