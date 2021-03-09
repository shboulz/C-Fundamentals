using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValueTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Booleans()
        {
            //bool isWorking; default is false
            //isWorking = true;
        }
        [TestMethod]
        public void Characters()
        {
            //char character = 'a';
            //char symbol = '?';
            //char numbers = '7';
            //char space = ' ';
            //char specialCharacter = '\n';
        }
        [TestMethod]
        public void WholeNumbers()
        {
            //byte byteExample = 255;
            //sbyte sByteExample = 127;
            //short shortExample = 32767;
            //Int16 anotherShortExample = 32000;
            //int intMin = -2147483647;
            //Int32 intMax = 2147483647;
            //long longExample = 9223372036854775807;
            //Int64 longMin = -9223372036854775807;

            //int a = 15;
            //int b = -15;

            //byte age = 25;
        }
        [TestMethod]
        public void Decimals()
        {
            //float floatExample = 1.045231f;
            //double doubleExample = 1.789053278907036d;
            //decimal decimalExample = 1.25789072890457897897897897897897m;

            Console.WriteLine(1.045231f);
            Console.WriteLine(1.789053278907036d);
            Console.WriteLine(1.25789072890457897897897897897897m);
        }
        enum PastryType { Cake, Cupcake, Eclaire, Petitfour, Croissant}
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Cupcake;
            PastryType anotherOne = PastryType.Eclaire;
        }
        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;

            DateTime birthday = new DateTime(1989, 1, 3);

            Console.WriteLine(birthday);
        }
    }
}
