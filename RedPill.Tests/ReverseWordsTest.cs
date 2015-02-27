using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadifyRedPill.Service;

namespace ReadifyRedPill.Tests
{
    [TestClass]
    public class ReverseWordsTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseWordsTest_When_Null_Should_Fail_Throw_ArgumentNullException()
        {
            RedPillService redPill = new RedPillService();
            redPill.ReverseWords(null);
        }

        [TestMethod]
        public void ReverseWordsTest_When_OneWordInput_Should_Return_ReverseString()
        {
            RedPillService redPill = new RedPillService();
            string result = redPill.ReverseWords("arman");
            Assert.AreEqual(result, "namra");
        }

        [TestMethod]
        public void ReverseWordsTest_When_InputWithSpace_Should_Return_ReverseStringSpace()
        {
            RedPillService redPill = new RedPillService();
            string result = redPill.ReverseWords("arman najafi");
            Assert.AreEqual(result, "namra ifajan");
        }

        [TestMethod]
        public void ReverseWordsTest_When_SpecialCharsInput_Should_Return_ReverseString()
        {
            RedPillService redPill = new RedPillService();
            string result = redPill.ReverseWords("¿Qué?");
            Assert.AreEqual(result, "?éuQ¿");
        }


        [TestMethod]
        public void ReverseWordsTest_When_PalindromesInput_Should_Return_SameString()
        {
            RedPillService redPill = new RedPillService();
            string result = redPill.ReverseWords("detartrated kayak detartrated");
            Assert.AreEqual(result, "detartrated kayak detartrated");
        }
    }
}
