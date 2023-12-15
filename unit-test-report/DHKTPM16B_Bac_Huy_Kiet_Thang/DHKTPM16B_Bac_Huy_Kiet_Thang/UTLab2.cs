using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UTLab2
{
    [TestClass]
    public class UTLab2
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            String actualResult = obj.SolveQuadratic(0, 0, 0, out float x1, out float x2);
            String expectedResult = "Vô số nghiệm";
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(double.NaN, x1);
            Assert.AreEqual(double.NaN, x2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            String actualResult = obj.SolveQuadratic(1, 0, 4, out float x1, out float x2);
            String expectedResult = "Vô nghiệm";
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(double.NaN, x1);
            Assert.AreEqual(double.NaN, x2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            String actualResult = obj.SolveQuadratic(0, -6, 12, out float x1, out float x2);
            String expectedResult = "Có 1 nghiệm";
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(2, x1);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            String actualResult = obj.SolveQuadratic(1, -5, 6, out float x1, out float x2);
            String expectedResult = "Có 2 nghiệm phân biệt";
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(2, x1);
            Assert.AreEqual(3, x2);
        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            String actualResult = obj.SolveQuadratic(1, -4, 4, out float x1, out float x2);
            String expectedResult = "Có nghiệm kép";
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(2, x1);
            Assert.AreEqual(2, x2);
        }
    }
}

