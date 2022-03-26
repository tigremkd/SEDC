using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Inheritance.Models
{
    public class Cat : Animal
    { 
        public bool IsLazy { get; set; }

        public Cat()
        {
            Console.WriteLine("New istance of Cat has been created by the parent constructor.");
        }
        
        public Cat(string name, string type, string race, bool isLazy)
            : base(name,type,race)
        {
            IsLazy = isLazy;
            Console.WriteLine("New istance of Cat has been created by the parent constructor with parametars.");
        }

        public override void Eat()
        {
            if (IsLazy)
            {
                Console.WriteLine("We need to feed the cat with a spoon.");
            }
            else
            {
                Console.WriteLine("The cat is eating the food.");
            }
            
        }

    }
}
