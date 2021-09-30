//https://v1study.com/csharp-practical-3-a618.html

namespace v1study_ZooManagmentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var cage1 = new Cage() { Number = 1 };
            var cage2 = new Cage() { Number = 2 };

            Zoo.AddCage(cage1);
            Zoo.AddCage(cage2);

            var doggie = new Dog("Rex");
            var cattie = new Cat("Kitty", new System.DateTime(2000, 1, 1), "Very nice cat");
            var tiggie = new Tiger("Leo", new System.DateTime(2010, 5, 7));

            cage1.AddAnimal(doggie);
            cage2.AddAnimal(cattie);
            cage2.AddAnimal(tiggie);


            foreach (var cage in Zoo.Cages)
            {
                foreach (var animal in cage.Animals)
                {
                    System.Console.WriteLine($"In cage {cage.Number} found a {animal.GetType().Name}: {animal.Info()}");
                    if (animal is Dog dog) dog.Speak();
                }
            }

        }
    }

}
