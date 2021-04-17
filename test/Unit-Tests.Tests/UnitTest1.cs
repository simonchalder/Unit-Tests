using System;
using System.Collections.Generic;
using Xunit;

namespace Unit_Tests.Tests
{
    public class UnitTests
    {

        // ------------ ARITHMATIC TESTS ----------------------------------

        [Fact]
        public void AddMethodReturnsSum()
        {
            Arithmatic NumTestObject = new Arithmatic();

            int result = NumTestObject.AddNumber(3, 45);

            Assert.Equal(48, result); // Does the method add the parameters given correctly
        }
        
        [Fact]
        public void MultMethodThrowsExceptionWithZero()
        {
            Arithmatic NumTestObject = new Arithmatic();

            Assert.Throws<ArgumentException>(() => NumTestObject.MultNumber(0, 5)); // Does the method throw the correct exception when given incorrect input
        }

        [Fact]
        public void AddToListCreatesItems()
        {
            Arithmatic NumTestObject = new Arithmatic();

            NumTestObject.NumList.Add(NumTestObject.MultNumber(3, 5));
            NumTestObject.NumList.Add(NumTestObject.MultNumber(12, 5));
            NumTestObject.NumList.Add(NumTestObject.AddNumber(7, 4));
            NumTestObject.NumList.Add(NumTestObject.AddNumber(6, 9));

            Assert.Equal(4, NumTestObject.NumList.Count); // Are items added to the list correctly
        }

        // ------------ STRING TESTS ----------------------------------

        [Fact]
        public void ConcatAddsWords()
        {
            Words WordTestObject = new Words();

            string result = WordTestObject.ConCatenator("Howdy", "Doody");

            Assert.Equal("HowdyDoody", result); // Does the method join 2 string parameters
        }

        [Fact]
        public void StretchingToUpper()
        {
            Words WordTestObject = new Words();

            string result = WordTestObject.WordStretcher("Hello");

            Assert.Equal("HELLO", result); // Does the method change the parameter given to upper case
        }

        [Fact]
        public void ShrinkingToLower()
        {
            Words WordTestObject = new Words();

            string result = WordTestObject.WordShrinker("HELLO");

            Assert.Equal("hello", result); // Does the method change the parameter given to lower case
        }

        [Fact]
        public void WordListInCorrectOrder()
        {
            Words WordTestObject = new Words();

            WordTestObject.WordList.Add("Hello");
            WordTestObject.WordList.Add("these");
            WordTestObject.WordList.Add("are");
            WordTestObject.WordList.Add("some");
            WordTestObject.WordList.Add("strings");

            Assert.Equal("Hello", WordTestObject.WordList[0]);
            Assert.Equal("are", WordTestObject.WordList[2]); // Are the added items found at the expected index in the list
            Assert.Equal("strings", WordTestObject.WordList[4]);
        }

        [Fact]
        public void SearchReturnsIndex()
        {
            Words WordTestObject = new Words();

            WordTestObject.WordList.Add("Hello");
            WordTestObject.WordList.Add("these");
            WordTestObject.WordList.Add("are");
            WordTestObject.WordList.Add("some");
            WordTestObject.WordList.Add("strings");

            Assert.Equal(4, WordTestObject.FindWordIndexInList("strings")); // Searching for an item in the list returns the expected index
            Assert.Equal(2, WordTestObject.FindWordIndexInList("are"));
        }

        //------------INTERFACE AND CLASS TESTS--------------------------

        [Fact]
        public void ClassInheritsFromInterface()
        {
            Lion myLion = new Lion();

            var result = myLion.animalNoise();
            var result2 = myLion.Hibernate();

            Assert.Equal("Roar", result); // A class created from 3 interfaces has inherited their methods
            Assert.Equal(false, result2);
        }

        //------------MORE METHOD TESTS------------------------------------

        [Fact]
        public void CorrectOverloadedByInput()
        {
            OtherMethods myMethods = new OtherMethods();

            int[] myArray = {34,45,71,66,90,33};

            var result = myMethods.OutputEqualsInput("Here is a string");
            var result2 = myMethods.OutputEqualsInput(436);
            var result3 = myMethods.OutputEqualsInput(myArray);

            Assert.True(result.GetType() == typeof(string)); // An overloaded method returns the expected result depending on the parameter type given
            Assert.True(result2.GetType() == typeof(int));
            Assert.True(result3.GetType() == typeof(int[]));
        }

        //--------------LIST TESTS------------------------------------------

        [Fact]
        public void ArrayAddedToListPlacesItemsInList() // Adding an array to a list adds the array items not the array itself
        {
            List<string> myList = new List<string>();

            string[] myArray = new string[3]{"item1", "item2", "item3"};

            myList.AddRange(myArray);

            Assert.Equal(myList[0], "item1");
            Assert.Equal(myList[1], "item2");
            Assert.Equal(myList[2], "item3");
        }

        [Fact]
        public void ListInsertionIsCorrect() // Adding an item to a specified index in a list moves other items up one index place
        {
            List<string> myList = new List<string>();

            string[] myArray = new string[3]{"item1", "item2", "item3"};
            myList.AddRange(myArray);
            myList.Insert(1, "newItem");

            Assert.Equal(myList[1], "newItem");
            Assert.Equal(myList[2], "item2");
        }
    }
}
