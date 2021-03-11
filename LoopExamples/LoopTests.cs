using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExamples
{
    [TestClass]
    public class LoopTests
    {
        [TestMethod]
        public void WhileLoops()
        {
            //just for setup
            int total = 1;

            //loop will keep running as long as the total isn't 10
            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            total = 0;
            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal Reached");
                    break;
                }
                total++;
            }


            Random random = new Random();

            int someCount;
            bool keepLooping = true;


            while (keepLooping)
            {
                // the 0 is inclusive and the 20 is exclusive. The range on this is 0-19
                someCount = random.Next(0, 20);

                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }

                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                }


            }


        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 21;

            //Initialization ; Conditional; Increment
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Adam", "Justin", "Joshua", "Amanda", "Danielle", "Ingeborg" };

            
            //All arrays have a length
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to the class {students[i]}!");
            }



        }

        [TestMethod]
        public void ForEachLoops()
        {
            string[] students = { "Adam", "Justin", "Joshua", "Amanda", "Danielle", "Ingeborg" };
            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in the class");
            }

            
            //a string is an array of char
            string myName = "Terry Eugene Edward Brown";
            string myNameNoSpaces="";
            foreach (char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                    myNameNoSpaces = myNameNoSpaces + letter;
                }
                
            }
            Console.WriteLine(myNameNoSpaces);
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int interator = 0;
            //I always run atleast once!
            do
            {
                Console.WriteLine("hello");
                interator++;
            } while (interator<5);

            do
            {
                Console.WriteLine("My do while condition is false");

            } while (false);

            while (false)
            {
                //linter is telling us the code is unreachable (linter runs in the background and shines a light on issues)
                Console.WriteLine("My while condition is false"); 
            }
        }
    }
}
