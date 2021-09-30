namespace Animal_InheritenceTest
{
    public class ZooAnimal : IZoo
    {
        public Animal Animal;
        public ZooAnimal(Animal animal, string location = "")
        {
            this.Animal = animal;
            Location = location;
        }

        public string Location { get; set; }
    }

}
