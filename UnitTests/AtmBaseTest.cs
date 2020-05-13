using NUnit.Framework;
using AtmCalculator;

namespace UnitTests
{
    public class AtmBaseTest
    {
        [Test]
        public void TestSomethingIsReturned()
        {
            var atmBase = new AtmBase();
            var testValue = atmBase.CalculateBills(100);

            Assert.IsNotNull(testValue);
        }

        [Test]
        public void TestOnlyHundredsAreReturned()
        {
            var atmBase = new AtmBase();
            var testValue = atmBase.CalculateBills(100);

            var expectedValue = new ReturnedBills
            {
                Hundreds = 1,
                Fifties = 0,
                Twenties = 0
            };

            Assert.AreEqual(testValue.Hundreds, expectedValue.Hundreds);
            Assert.AreEqual(testValue.Fifties, expectedValue.Fifties);
            Assert.AreEqual(testValue.Twenties, expectedValue.Twenties);
        }

        [Test]
        public void TestCorrectValueIsReturned()
        {
            var atmBase = new AtmBase();
            var testValue = atmBase.CalculateBills(170);

            var expectedValue = new ReturnedBills
            {
                Hundreds = 1,
                Fifties = 1,
                Twenties = 1
            };

            Assert.AreEqual(testValue.Hundreds, expectedValue.Hundreds);
            Assert.AreEqual(testValue.Fifties, expectedValue.Fifties);
            Assert.AreEqual(testValue.Twenties, expectedValue.Twenties);
        }


        [Test]
        public void TestOnlyFiftiesAreReturned()
        {
            var atmBase = new AtmBase();
            var testValue = atmBase.CalculateBills(50);

            var expectedValue = new ReturnedBills
            {
                Hundreds = 0,
                Fifties = 1,
                Twenties = 0
            };

            Assert.AreEqual(testValue.Hundreds, expectedValue.Hundreds);
            Assert.AreEqual(testValue.Fifties, expectedValue.Fifties);
            Assert.AreEqual(testValue.Twenties, expectedValue.Twenties);
        }


        [Test]
        public void TestOnlyTwentiesAreReturned()
        {
            var atmBase = new AtmBase();
            var testValue = atmBase.CalculateBills(60);

            var expectedValue = new ReturnedBills
            {
                Hundreds = 0,
                Fifties = 0,
                Twenties = 3
            };

            Assert.AreEqual(testValue.Hundreds, expectedValue.Hundreds);
            Assert.AreEqual(testValue.Fifties, expectedValue.Fifties);
            Assert.AreEqual(testValue.Twenties, expectedValue.Twenties);
        }
    }
}