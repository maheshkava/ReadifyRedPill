using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadifyRedPill.Service;

namespace ReadifyRedPill.Tests
{
    [TestClass]
    public class FibonacciNumberTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FibonacciNumberTest_When_Greaterthan92_Should_Faill_Throw_ArgumentOutOfRangeException()
        {
            RedPillService redPill = new RedPillService();
            redPill.FibonacciNumber(93);
        }

        [TestMethod]
        public void FibonacciNumberTest_When_0_Should_Return_0()
        {
            Assert.AreEqual(TestFib(0), 0);
        }

        [TestMethod]
        public void FibonacciNumberTest_When_ValidInput_ShouldPass()
        {
            Assert.AreEqual(TestFib(0), 0);
            Assert.AreEqual(TestFib(1), 1);
             Assert.AreEqual(TestFib( 3), 2);
             Assert.AreEqual(TestFib( 4), 3);
             Assert.AreEqual(TestFib( 5), 5);
             Assert.AreEqual(TestFib( 6), 8);
             Assert.AreEqual(TestFib( 7), 13);
             Assert.AreEqual(TestFib( 46), 1836311903);
             Assert.AreEqual(TestFib( 47), 2971215073);
             Assert.AreEqual(TestFib( 92), 7540113804746346429);
             Assert.AreEqual(TestFib( 2), 1);
        }

        [TestMethod]
        public void FibonacciNumberTest_When_Negative_1_Input_ShouldReturn_1()
        {
            Assert.AreEqual(TestFib(-1), 1);
        }

        [TestMethod]
        public void FibonacciNumberTest_When_Negative_Input_ShouldPass()
        {
            Assert.AreEqual(TestFib(-1), 1);
            Assert.AreEqual(TestFib(-4), -3);
            Assert.AreEqual(TestFib(-5), 5);
            Assert.AreEqual(TestFib(- 3), 2);
            Assert.AreEqual(TestFib(-2), -1);
            Assert.AreEqual(TestFib(-3), 2);
            Assert.AreEqual(TestFib( -3), 2);
            Assert.AreEqual(TestFib( -92), -7540113804746346429);
            Assert.AreEqual(TestFib( -47), 2971215073);
            Assert.AreEqual(TestFib( -46), -1836311903);
            Assert.AreEqual(TestFib( -7), 13);
            Assert.AreEqual(TestFib(-6), -8);           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FibonacciNumberTest_When_Lessthan92_Should_Fail_Throw_ArgumentOutOfRangeException()
        {
            RedPillService redPill = new RedPillService();
            long result = redPill.FibonacciNumber(-93);

        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void FibonacciNumberTest_When_MaxInt_Should_Fail_Throw_ArgumentOutOfRangeException()
        //{
        //    RedPillService redPill = new RedPillService();
        //    long result = redPill.FibonacciNumber(Int16.MaxValue);
        //}

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FibonacciNumberTest_When_MaxLong_Should_Fail_Throw_ArgumentOutOfRangeException()
        {
            RedPillService redPill = new RedPillService();
            long result = redPill.FibonacciNumber(long.MaxValue);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FibonacciNumberTest_When_MinLong_Should_Fail_Throw_ArgumentOutOfRangeException()
        {
            RedPillService redPill = new RedPillService();
            long result = redPill.FibonacciNumber(long.MinValue);
        }

        private static long TestFib(long number)
        {
            RedPillService redPill = new RedPillService();
            long result = redPill.FibonacciNumber(number);
            return result;
            
        }
         [TestMethod]
        public void TEST()
        {
            Assert.AreEqual(TestFib(0), 0);
        }
    }
}
