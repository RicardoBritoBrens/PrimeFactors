using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using static PrimeFactorsTest.PrimeFactors;

namespace PrimeFactorsTest
{
    public class UseCases
    {
        [SetUp]
        public void Setup()
        {
        }

        private List<int> list(params int[] ints)
        {
            List<int> list = new List<int>();
            foreach (var item in ints)
            {
                list.Add(item);
            }
            return list;
        }

        [Test]
        public void TestOne()
        {
            Assert.AreEqual(list(), Generate(1));
        }

        [Test]
        public void SecondTest()
        {
            Assert.AreEqual(list(2), Generate(2));
        }

        [Test]
        public void TestThree()
        {
            Assert.AreEqual(list(3), Generate(3));
        }

        [Test]
        public void FourthTest()
        {
            Assert.AreEqual(list(2, 2), Generate(4));
        }

        [Test]
        public void FifthTest()
        {
            Assert.AreEqual(list(2, 3), Generate(6));
        }

        [Test]
        public void SexthTest()
        {
            Assert.AreEqual(list(2, 2, 2), Generate(8));
        }

        [Test]
        public void SevenThTest()
        {
            Assert.AreEqual(list(3, 3), Generate(9));
        }
    }
}