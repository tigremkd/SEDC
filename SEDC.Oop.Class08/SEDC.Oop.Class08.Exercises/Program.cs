using System;
using System.Collections.Generic;

namespace SEDC.Oop.Class08.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            phoneBook.Add("Igor", "123456");
            phoneBook.Add("Trajan", "222333");
            phoneBook.Add("Nikola", "444555");
            phoneBook.Add("Sara", "666111");
            phoneBook.Add("Ana", "939393");

            Console.WriteLine("Enter persons name: ");
            string userChoice = Console.ReadLine();
            

            foreach (KeyValuePair<string,string> names in phoneBook)
            {
                //Console.WriteLine(phoneBook[names.Key]);
                //Console.WriteLine(userChoice);
                if(userChoice == names.Key)
                {
                    Console.WriteLine($"The number of {names.Key} is " + names.Value);
                    //continue;
                }
                else
                {
                    Console.WriteLine($"Person named {userChoice} does not exsist in the phonebook. ");
                    //break;
                }
            }





            Console.ReadLine();
        }
    }
}
