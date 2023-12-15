using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTLab7
{
    [TestClass]
    public class UTLab7
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();
            int[] array = { 1, 2, 3, 4, 5 };
            int actual = method.Largest(array);
            int expect = 5;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();
            int[] array = { };
            int actual = method.Largest(array);
            int expect = 2147483647;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();
            int[] array = {8};
            int actual = method.Largest(array);
            int expect = 8;
            Assert.AreEqual(expect, actual);
        }
    }
}
