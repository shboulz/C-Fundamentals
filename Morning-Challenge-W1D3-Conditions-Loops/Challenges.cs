using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Morning_Challenge_W1D3_Conditions_Loops
{
    [TestClass]
    public class Challenges
    {
        [TestMethod]
        public void PartOne()
        {
            string challengeWord = "Supercalifragilisticexpialidocious";

            foreach (char letter in challengeWord)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void PartTwo()
        {
            string challengeWordTwo = "Supercalifragilisticexpialidocious";

            foreach (char letter in challengeWordTwo)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }
        }

        [TestMethod]
        public void BonusOne()
        {
            string longWord = "Supercalifragilisticexpialidocious";
            Console.WriteLine(longWord.Length);
        }

        [TestMethod]
        public void BonusTwo()
        {
            string longWord = "Supercalifragilisticexpialidocious";
            foreach (char letter in longWord)
            {
                if (letter == 'l')
                {
                    Console.WriteLine("L");
                }
            }
        }
    }
}
