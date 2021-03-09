using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ReferenceTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Strings()
        {
            string name;

            string declared;
            declared = "this is initialized";

            string declareAndInitialize = "This is both declaring and intializing.";

            string firstName = "Jeff";
            string lastName = "Deacon";

            string concatenatedFullName = firstName + " " + lastName;

            string interpolationFullName = $"{firstName} {lastName}";

            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(interpolationFullName);
            Console.WriteLine(compositeFullName);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample };
            string thirdItem = stringArray[2];

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            stringArray[0] = "Hey There";
            Console.WriteLine(stringArray[0]);

            List<string> listOfStrings = new List<string>();
            List<int> listOfInts = new List<int>();

            listOfStrings.Add("First string for our lists");
            listOfInts.Add(123456);

            Console.WriteLine(listOfInts[0]);


            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm next");
            firstInFirstOut.Enqueue("I'm third");

            while (firstInFirstOut.Count > 0)
            {
                string firstItem = firstInFirstOut.Dequeue();
                Console.WriteLine(firstItem);
                Console.WriteLine(firstInFirstOut.Count);
            }
            // Index needs to be unique in dictionary
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(7, "Agent");

            string valueSeven = keyAndValue[7];
            Console.WriteLine(valueSeven);

            //Different Types of Collections
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            //Different Types of Collections
            HashSet<int> uniqueList = new HashSet<int>();
            //Different Types of Collections
            Stack<string> lastInFirstOut = new Stack<string>();
        }

        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next(0,100);

            Console.WriteLine(randomNumber);
        }
    }
}
