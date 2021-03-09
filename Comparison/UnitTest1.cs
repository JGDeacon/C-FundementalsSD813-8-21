using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            //start w/ our variables
            int age = 25;
            string userName = "Terry";

            //Check if values are equal use == to compare values, = assigns a value.
            bool isEqual = age == 41;

            Console.WriteLine(isEqual);

            bool isUserTerry = userName == "Terry";
            Console.WriteLine(isUserTerry);
            Console.WriteLine("User is 41: " +isEqual);

            // != means not equal. So 3 != 2 would be true
            bool notEqual = age != 122;
            Console.WriteLine($"User is not 122: {notEqual}");

            bool userIsNotJustin = userName != "Justin";
            Console.WriteLine($"User name is not Justin: {userIsNotJustin}");

            List<string> firstList = new List<string>();
            firstList.Add(userName);            
            List<string> secondList = new List<string>();
            secondList.Add(userName);

            
            //Compare the list
            bool listsAreEqual = firstList == secondList;
            Console.WriteLine($"The lists are equal by memory location: {listsAreEqual}");
            bool listsAreEqualByIndex = firstList[0] == secondList[0];
            Console.WriteLine($"The lists are equal by username: {listsAreEqualByIndex}");

            //greater than
            bool greaterThan = age > 12;

            //greater than or equal to

            bool greaterThanOrEqual = age >= 24;

            //We have the OR '||'
            bool orValue = isEqual || greaterThan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;


            Console.WriteLine($"True or True {tOrT}");
            Console.WriteLine($"True or False {tOrF}");
            Console.WriteLine($"False or True {fOrT}");
            Console.WriteLine($"False or False {fOrF}");

            // and '&&'

            bool andValue = greaterThan && orValue;

            bool tAndt = trueValue && trueValue;
            bool tAndf = trueValue && falseValue;
            bool fAndt = falseValue && trueValue;
            bool fAndf = falseValue && falseValue;

            Console.WriteLine($"True or True {tAndt}");
            Console.WriteLine($"True or False {tAndf}");
            Console.WriteLine($"False or True {fAndt}");
            Console.WriteLine($"False or False {fAndf}");

        }
    }
}
