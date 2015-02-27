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
    public class WhatShapeIsThisTest
    {
        [TestMethod]
        public void WhatShapeIsThisTest_When_BadInput_Should_Return_Error()
        {
            Assert.AreEqual(TestWhatShapeIsThis(0, 0, 0), TriangleType.Error);
            Assert.AreEqual(TestWhatShapeIsThis(1, 1, 0), TriangleType.Error);
            Assert.AreEqual(TestWhatShapeIsThis(1, 1, 2), TriangleType.Error);
            Assert.AreEqual(TestWhatShapeIsThis(1, 0, 1), TriangleType.Error);
            Assert.AreEqual(TestWhatShapeIsThis(2, 1, 1), TriangleType.Error);
            Assert.AreEqual(TestWhatShapeIsThis(1, 2, 3), TriangleType.Error);
            Assert.AreEqual(TestWhatShapeIsThis(-1, -1, -1), TriangleType.Error);
            Assert.AreEqual(TestWhatShapeIsThis(-1, 1, 1), TriangleType.Error);
            Assert.AreEqual(TestWhatShapeIsThis(1, -1, 1), TriangleType.Error);
            Assert.AreEqual(TestWhatShapeIsThis(1, 1, -1), TriangleType.Error);
            Assert.AreEqual(TestWhatShapeIsThis(0, 1, 1), TriangleType.Error);
            Assert.AreEqual(TestWhatShapeIsThis(1, 2, 1), TriangleType.Error);
            Assert.AreEqual(TestWhatShapeIsThis(1, 1, 2147483647), TriangleType.Error);
            Assert.AreEqual(TestWhatShapeIsThis(-2147483648, -2147483648, -2147483648), TriangleType.Error);
        }


        [TestMethod]
        public void WhatShapeIsThisTest_When_TwoSidesEqual_Should_Return_Isosceles()
        {
            RedPillService redPill = new RedPillService();
            TriangleType type = redPill.WhatShapeIsThis(2, 2, 1);
            Assert.AreEqual(type, TriangleType.Isosceles);
            Assert.AreEqual(TestWhatShapeIsThis(2, 2, 3), TriangleType.Isosceles);
            Assert.AreEqual(TestWhatShapeIsThis(2, 3, 2), TriangleType.Isosceles);
            Assert.AreEqual(TestWhatShapeIsThis(3, 2, 2), TriangleType.Isosceles);

        }

        [TestMethod]
        public void WhatShapeIsThisTest_When_SidesEqual_Should_Return_Equilateral()
        {
            RedPillService redPill = new RedPillService();
            TriangleType type = redPill.WhatShapeIsThis(2, 2, 2);
            Assert.AreEqual(type, TriangleType.Equilateral);
            Assert.AreEqual(TestWhatShapeIsThis(1, 1, 1), TriangleType.Equilateral);
            Assert.AreEqual(TestWhatShapeIsThis(2, 2, 2), TriangleType.Equilateral);
            Assert.AreEqual(TestWhatShapeIsThis(2147483647, 2147483647, 2147483647), TriangleType.Equilateral);
            Assert.AreEqual(TestWhatShapeIsThis(2147483647, 2147483647, 2147483647), TriangleType.Equilateral);


        }

        [TestMethod]
        public void WhatShapeIsThisTest_When_NoEqualSides_Should_Return_Scalene()
        {
            RedPillService redPill = new RedPillService();
            TriangleType type = redPill.WhatShapeIsThis(12, 6, 14);
            Assert.AreEqual(type, TriangleType.Scalene);
            Assert.AreEqual(TestWhatShapeIsThis(2, 3, 4), TriangleType.Scalene);
            Assert.AreEqual(TestWhatShapeIsThis(3, 4, 2), TriangleType.Scalene);
            Assert.AreEqual(TestWhatShapeIsThis(4, 2, 3), TriangleType.Scalene);
            Assert.AreEqual(TestWhatShapeIsThis(4, 3, 2), TriangleType.Scalene);

        }

        [TestMethod]
        public void WhatShapeIsThisTest_When_MaxIntSize_Should_Return_Equilateral()
        {
            Assert.AreEqual(TestWhatShapeIsThis(Int32.MaxValue, Int32.MaxValue, Int32.MaxValue), TriangleType.Equilateral);
        }


        [TestMethod]
        public void WhatShapeIsThisTest_When_MinIntSize_Should_Return_Error()
        {
            Assert.AreEqual(TestWhatShapeIsThis(Int32.MinValue, Int32.MinValue, Int32.MinValue), TriangleType.Error);
        }

        private static TriangleType TestWhatShapeIsThis(int a, int b, int c)
        {
            RedPillService redPill = new RedPillService();
            return redPill.WhatShapeIsThis(a, b, c);
        }

    }
}
