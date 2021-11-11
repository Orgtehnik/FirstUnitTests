using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void FirstStringAndSecondString_AreEqual_ReturnTrue()
        {
            string FirstString = "hello";
            string SecondString = "hello";

            Assert.AreEqual(FirstString, SecondString, "Strings are not equal");
        }

        [Test]
        public void FirstListAndSecondList_AreEqual_ReturnTrue()
        {
            var FirstStringList = new List<string>
            {
                "New York",
                "London",
                "Mumbai",
                "Chicago"
            };

            var SecondStringList = new List<string>
            {
                "New York",
                "London",
                "Mumbai",
                "Chicago"
            };

            Assert.AreEqual(FirstStringList, SecondStringList, "Lists are not equal");

        }

        [Test]
        public void FirstStringListHaveStringCity_ReturnTrue()
        {
            var FirstStringList = new List<string>
            {
                "New York",
                "London",
                "Mumbai",
                "Chicago"
            };
            string city = "Chicago";

            Assert.True(FirstStringList.Contains(city), $"List does not contain {city}");
        }

        [Test]
        public void FirstNumberAndSecondNumber_FirstNumberMoreSecondNumber_ReturnTrue()
        {
            int FirstNumber = 10;
            int SecondNumber = 20;

            Assert.True(FirstNumber < SecondNumber, "Numbers are not equal");
        }

       
    }
}