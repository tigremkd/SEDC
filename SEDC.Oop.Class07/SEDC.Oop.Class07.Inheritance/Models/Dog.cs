using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Inheritance.Models
{
    public class Dog : Animal
    {
        public bool IsPlayful { get; set; }

        public Dog()
        {
            Console.WriteLine("New istance of Dog has been created by the parent constructor.");

        }
        public Dog(string name, string type)
            :base(name, type, "Doggy")
        {
            IsPlayful = false;
            Console.WriteLine("New istance of Dog has been created by the parent constructor with parametars.");
        }
        public void DogEat()
        {
            base.Eat();
        }
    }

}
