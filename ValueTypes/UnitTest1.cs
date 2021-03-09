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
            bool isDeclared;
            isDeclared = true;

            bool isDeclatedAndInitialized = false;

            isDeclatedAndInitialized = true;



        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char numbers = '4';
            char space = ' ';
            // You can even use special charecters
            char special = '\n'; 

        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255; // 255 is the max 0-255 = 256
            sbyte sByteExample = 127; //127 is the max 0-127 = 128
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483647;
            Int32 intMax = 2147483647;
            long longMin = -9223372036854775807; // Min -9223372036854775807
            long longMax = 9223372036854775807; // Max 9223372036854775807


            int a = 15;
            int b = -15;
            byte age = 25;

        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExample = 1.2578907289045789789789789787897m;

            //see how many digits each type allows
            Console.WriteLine(1.2578907289045789789789789787897f);
            Console.WriteLine(1.2578907289045789789789789787897d);
            Console.WriteLine(1.2578907289045789789789789787897m);
            
        }
        enum PastryType { Cake, Cupcake, Eclair, Petitfour, Croissant}
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Cupcake;
            PastryType anotherOne = PastryType.Cake;

        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;

            DateTime birthday = new DateTime(1978, 6, 8);

            Console.WriteLine(today);

        }
    }
}
