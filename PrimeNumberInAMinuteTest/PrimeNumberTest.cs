using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumberInAMinute;

namespace PrimeNumberInAMinuteTest
{
    [TestClass]
    public class PrimeNumberTest
    {
        [TestMethod]
        public void PrimeNumberNotGreaterThan100()
        {
            IMaxPrimeNumber iPN = new MaxPrimeNumber();
            uint actual = iPN.findMaxPrime(100, null);
            uint expect = 97;
            Assert.AreEqual(expect, actual);
        }

        public void PrimeNumberNotGreaterThan113()
        {
            IMaxPrimeNumber iPN = new MaxPrimeNumber();
            uint actual = iPN.findMaxPrime(113, null);
            uint expect = 113;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void PrimeNumberNotGreaterThan2()
        {
            IMaxPrimeNumber iPN = new MaxPrimeNumber();
            uint actual = iPN.findMaxPrime(2, null);
            uint expect = 2;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void PrimeNumberNotGreaterThan()
        {
            IMaxPrimeNumber iPN = new MaxPrimeNumber();
            uint actual = iPN.findMaxPrime(3, null);
            uint expect = 3;
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void PrimeNumberNotGreater2WithEratos()
        {
            IMaxPrimeNumber iPN = new EratosMaxPrimeNumber();
            uint actual = iPN.findMaxPrime(2, null);
            uint expect = 2;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void PrimeNumberNotGreater3WithEratos()
        {
            IMaxPrimeNumber iPN = new EratosMaxPrimeNumber();
            uint actual = iPN.findMaxPrime(3, null);
            uint expect = 3;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void PrimeNumberNotGreater100WithEratos()
        {
            IMaxPrimeNumber iPN = new EratosMaxPrimeNumber();
            uint actual = iPN.findMaxPrime(100, null);
            uint expect = 97;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void PrimeNumberNotGreater113WithEratos()
        {
            IMaxPrimeNumber iPN = new EratosMaxPrimeNumber();
            uint actual = iPN.findMaxPrime(113, null);
            uint expect = 113;
            Assert.AreEqual(expect, actual);
        }


    }
}
