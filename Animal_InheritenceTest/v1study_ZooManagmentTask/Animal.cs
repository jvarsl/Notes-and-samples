using System;
//https://v1study.com/csharp-practical-3-a618.html
namespace v1study_ZooManagmentTask
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Description { get; set; }

        public int Age => (int)((DateTime.Today - DateOfBirth).TotalDays / 365.2425);

        public string Info()
        {
            string info = $"My name is {Name}, I'm {Age}";
            info += !string.IsNullOrEmpty(Description)
                ? $" and about me: {Description}"
                : ".";

            return info;
        }

        public abstract void Speak();

        public Animal()
        {
        }
        public Animal(string name) : this(name, DateTime.Today, string.Empty)
        {
        }
        public Animal(string name, DateTime dateOfBirth) : this(name, dateOfBirth, string.Empty)
        {
        }
        public Animal(string name, DateTime dateOfBirth, string description)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Description = description;
        }
    }
}
