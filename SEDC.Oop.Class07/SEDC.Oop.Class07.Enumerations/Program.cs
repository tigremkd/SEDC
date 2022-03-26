using SEDC.Oop.Class07.Enumerations.Enums;
using SEDC.Oop.Class07.Enumerations.Models;
using System;

namespace SEDC.Oop.Class07.Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrator admin = new Administrator("Bob");
            admin.Role = Roles.SuperGuest;
            Console.WriteLine(admin.Role);
            bool isValid = Enum.TryParse("2", out Roles role);

            Console.ReadLine();
        }
    }
}
