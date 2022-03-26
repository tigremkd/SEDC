using System;
using System.Collections;
using System.Collections.Generic;

namespace SEDC.OOp.Class08.CsharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            string[] strings = new string[4];
            string[] strings2 = new string[] { "Hello", "World" };
            GoThruCollection(strings2, "Array");
            Array.Resize(ref strings2, strings2.Length + 1);
            strings2[strings2.Length - 1] = "!";
            GoThruCollection(strings2, "Array");
            #endregion

            #region Lists
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(7);
            numbers.Add(9);
            numbers.Add(3);
            numbers.Remove(9);
            Console.WriteLine("List count is : " + numbers.Count);
            GoThruCollection(numbers, "List of integers");
            #endregion

            #region Dictiornery
            Dictionary<string, string> dictioneryOne = new Dictionary<string, string>();
            dictioneryOne.Add("song1", "Winds of change");
            dictioneryOne.Add("song2", "Enter Sandman");
            dictioneryOne.Add("animal", "dog");
            GoThruCollection(dictioneryOne, "Dictonery");

            Dictionary<int, string> dictioneryTwo = new Dictionary<int, string>
            {
                {1, "Hello" },
                {2, "World" },
                {3, "!" }
            };

            Console.WriteLine(dictioneryOne["song2"]);
            Console.WriteLine(dictioneryTwo[2]);
            Console.WriteLine("Length: " + dictioneryTwo.Count);

            Dictionary<int, MyType> myTypeDictonery = new Dictionary<int, MyType>();
            Dictionary<string, List<string>> bandsSongsDictionery = new Dictionary<string, List<string>>();

            foreach(KeyValuePair<int,string> keyValue in dictioneryTwo)
            {
                Console.WriteLine("======================");
                Console.WriteLine(dictioneryTwo[keyValue.Key]);

            }
            //dictioneryTwo.Remove(4);
            #endregion

            #region Stack and Queue
            Console.WriteLine("=======================Queue=========================");
            Queue<int> someQueue = new Queue<int>();
            someQueue.Enqueue(25);
            someQueue.Enqueue(2);
            someQueue.Enqueue(3);
            someQueue.Enqueue(111);

            int firstElement = someQueue.Dequeue();
            Console.WriteLine(firstElement);
            GoThruCollection(someQueue, "Queue");
            Console.WriteLine(someQueue.Peek());
            Console.WriteLine("Length: " + someQueue.Count);

            Console.WriteLine("=======================STACK=========================");
            Stack<string> someStack = new Stack<string>();
            someStack.Push("Hey");
            someStack.Push("Hello");
            someStack.Push("Hi");
            someStack.Push("Zdravo");

            string item = someStack.Pop();
            Console.WriteLine("POP: " + item);
            Console.WriteLine("Peek" + someStack.Peek());
            Console.WriteLine("Length: " + someStack.Count);
    
            GoThruCollection(someStack, "Stack");

            #endregion

            Console.ReadLine();
        }

        public static void GoThruCollection(IEnumerable collection, string name)
        {
            Console.WriteLine("Collection {0} items", name);
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine();
        }
        
        public class MyType { };
    }
}
