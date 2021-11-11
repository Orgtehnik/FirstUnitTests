using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void FirstStringAndSecondString_AreEqual_ReturnTrue()
        {
            string firstString = "hello";
            string secondString = "hello";

            Assert.AreEqual(firstString, secondString, "Strings are not equal");
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
            string nameOfCity = "Chicago";

            Assert.True(FirstStringList.Contains(nameOfCity), $"List does not contain {nameOfCity}");
        }

        [Test]
        public void FirstNumberAndSecondNumber_FirstNumberMoreSecondNumber_ReturnTrue()
        {
            int firstNumber = 10;
            int secondNumber = 20;

            Assert.True(firstNumber < secondNumber, "Numbers are not equal");
        }

        [Test]
        public void SomethingTest()
        {
            string text = "abc999defghijklmnopqrstuvwxyzABCXYZ123@0123456789 _ + -.,!@#$%^&*();\'/|<>"+ "\u0022"+"12345 - 98.7 3.141 .6180 9,000 + 42555.123.4567 + 1 - (800) - 555 - 2468 foo @demo.net bar.ba @test.co.uk www.demo.com";
            
            
        }
    }
}