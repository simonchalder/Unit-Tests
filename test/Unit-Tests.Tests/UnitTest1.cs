using System;
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

            Assert.Equal(48, result);
        }
        
        [Fact]
        public void MultMethodReturnsSum()
        {
            Arithmatic NumTestObject = new Arithmatic();

            int result = NumTestObject.MultNumber(3, 5);

            Assert.Equal(15, result);
        }

        [Fact]
        public void AddToListCreatesItems()
        {
            Arithmatic NumTestObject = new Arithmatic();

            NumTestObject.NumList.Add(NumTestObject.MultNumber(3, 5));
            NumTestObject.NumList.Add(NumTestObject.MultNumber(12, 5));
            NumTestObject.NumList.Add(NumTestObject.AddNumber(7, 4));
            NumTestObject.NumList.Add(NumTestObject.AddNumber(6, 9));

            Assert.Equal(4, NumTestObject.NumList.Count);
        }

        // ------------ STRING TESTS ----------------------------------

        [Fact]
        public void ConcatAddsWords()
        {
            Words WordTestObject = new Words();

            string result = WordTestObject.ConCatenator("Howdy", "Doody");

            Assert.Equal("HowdyDoody", result);
        }

        [Fact]
        public void StretchingToUpper()
        {
            Words WordTestObject = new Words();

            string result = WordTestObject.WordStretcher("Hello");

            Assert.Equal("HELLO", result);
        }

        [Fact]
        public void ShrinkingToLower()
        {
            Words WordTestObject = new Words();

            string result = WordTestObject.WordShrinker("HELLO");

            Assert.Equal("hello", result);
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

            Assert.Equal(5, WordTestObject.WordList.Count);
            Assert.Equal("Hello", WordTestObject.WordList[0]);
            Assert.Equal("are", WordTestObject.WordList[2]);
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

            Assert.Equal(5, WordTestObject.WordList.Count);
            Assert.Equal(4, WordTestObject.FindWordIndexInList("strings"));
            Assert.Equal(2, WordTestObject.FindWordIndexInList("are"));
        }
    }
}
