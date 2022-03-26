using SEDC.Oop.Class07.Inheritance.Models;
using System;

namespace SEDC.Oop.Class07.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal() { Name = "Dambo", Id = 5, Type= "Elephant", Race = "WhiteOnes"};
            animal.Eat();
            Console.WriteLine();

            Dog dog = new Dog() { Name = "Sparky", Id = 2, Type = "Dog", Race ="Striter", IsPlayful = true };
            dog.Eat();
            Console.WriteLine();
            Cat cat = new Cat() { Name = "Badi", Id = 1, Type = "Cat" , Race = "British", IsLazy = true };
            cat.Eat();
            //cat.CatEat();
            Console.WriteLine();
            //Dog dog2 = new Dog("Tgre", "Dog");

            //Cat cat2 = new Cat("Maca", "Cat", "Scotish", true);


            Console.ReadLine();
        }
    }
}
