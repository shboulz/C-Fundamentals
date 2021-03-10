﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExamples
{
    [TestClass]
    public class LoopTests
    {
        [TestMethod]
        public void WhileLoops()
        {
            // Just for setup...
            int total = 1;

            //Please keep runniing as long as total isnt 10
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
                    Console.WriteLine("Goal Reached!");
                    break;
                }

                total++;
            }

            // new setup
            Random random = new Random();

            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                //0 inclusive, 20 is exclusive, (0-19)
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

            // Initialization Conditional Increment
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Adam", "Justin", "James", "Addey", "Josh", "Dani" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to the class {students[i]}");
            }
        }
        [TestMethod]
        public void ForEachLoops()
        {
            string[] students = { "Adam", "Justin", "James", "Addey", "Josh", "Dani" };

            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in the class");
            }

            string myName = "Addey Qasim Al Shboul";

            foreach (char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            // I always run atleast once!!!!!!!!!
            do
            {
                Console.WriteLine("Hello");
                iterator++;
            } while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is false!!!!!");
            } while (false);

            while (false)
            {
                // linter is telling us the code is unreachable (background of VS)
                Console.WriteLine("My while condition is false!");  
            }

        }
    }
}
