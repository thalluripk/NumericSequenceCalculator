using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCalculator.Services;

namespace NumericSequenceCalculator.Tests.Services
{
    [TestClass]
    public class NumericSequenceGeneratorTest
    {
        [TestMethod]
        public void TestGenerateNumberSequence()
        {
            Assert.AreEqual<string>("1 2 3 4 5 6 7 8 9 10", NumericSequenceGenerator.GenerateNumberSequence(10));
        }

        [TestMethod]
        public void TestGenerateOddNumberSequence()
        {
            Assert.AreEqual<string>("1 3 5 7 9 10", NumericSequenceGenerator.GenerateOddNumberSequence(10));
        }

        [TestMethod]
        public void TestGenerateEvenNumberSequence()
        {
            Assert.AreEqual<string>("2 4 6 8 10", NumericSequenceGenerator.GenerateEvenNumberSequence(10));
        }

        [TestMethod]
        public void TestGenerateEncodedNumberSequence()
        {
            Assert.AreEqual<string>("1 2 C 4 E C 7 8 C E", NumericSequenceGenerator.GenerateEncodedNumberSequence(10));
        }

        [TestMethod]
        public void TestGenerateFibonacciNumberSequence()
        {
            Assert.AreEqual<string>("1 2 3 5 8 10", NumericSequenceGenerator.GenerateFibonacciNumberSequence(10));
        }
    }
}
