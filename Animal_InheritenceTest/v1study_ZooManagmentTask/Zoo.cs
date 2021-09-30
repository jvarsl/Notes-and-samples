//https://v1study.com/csharp-practical-3-a618.html
using System.Collections.Generic;
using System.Linq;

namespace v1study_ZooManagmentTask
{
    public static class Zoo
    {
        public static List<Cage> Cages = new List<Cage>();

        public static void AddCage(Cage cage)
        {
            Cages.Add(cage);
            System.Console.WriteLine("Cage added");
        }
        public static void RemoveCage(int number)
        {
            var cage = Cages.Where(x => x.Number == number).FirstOrDefault();
            if (cage is null)
            {
                System.Console.WriteLine("Cage not found");
            }
            else
            {
                Cages.Remove(cage);
                System.Console.WriteLine("Cage removed");
            }
        }
    }

}
