//https://v1study.com/csharp-practical-3-a618.html
using System.Collections.Generic;
using System.Linq;

namespace v1study_ZooManagmentTask
{
    public class Cage
    {
        public int Number { get; init; }
        public List<Animal> Animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            System.Console.WriteLine($"{animal.Name} added.");
        }

        public void RemoveAnimal(string name)
        {
            if (Animals.Exists(x => x.Name == name))
            {
                var animal = Animals.Where(x => x.Name == name).FirstOrDefault();
                Animals.Remove(animal);
                System.Console.WriteLine($"{animal.Name} removed.");
            }
            else
            {
                System.Console.WriteLine($"{name} not found.");
            }
        }

    }

}
