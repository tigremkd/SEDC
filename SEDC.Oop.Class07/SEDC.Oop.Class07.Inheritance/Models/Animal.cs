using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Inheritance.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Race { get; set; }

        public Animal()
        {
            Console.WriteLine("New istance of an animal has been created, this is the Animal Constructor");
        }
        public Animal(string name, string type, string race)
        {
            Name = name;
            Type = type;
            Race = race;
            Console.WriteLine("New istance of an animal has been created, this is the Animal Constructor with parametars.");
        }
        public virtual void Eat()
        {
            Console.WriteLine($"The {Type} animal is named {Name} is eating");
        }
    }
}
