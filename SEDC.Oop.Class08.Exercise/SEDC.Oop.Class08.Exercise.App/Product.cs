using SEDC.Oop.Class08.Exercise.App.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class08.Exercise.App
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        
        public Category Category { get; set; }
    }
}
