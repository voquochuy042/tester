using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UTLab8
{
    [TestClass]
    public class UTLab8
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] list = new int[] { 5, 4, 3, 9, 6, 1 };
            obj.QuickSort(list, 0, 5);
            int[] expectedResult = new int[] { 1, 3, 4, 5, 6, 9 };
            CollectionAssert.AreEqual(expectedResult, list);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] list = new int[] { 10, 7, 8, 9, 1, 5, 8 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => obj.QuickSort(list, -3, 6));
        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] list = new int[] { 10, 75, 32, 78, 33, 59, 48, 54 };
            obj.QuickSort(list, 10, 7);
            int[] expectedResult = new int[] { 10, 75, 32, 78, 33, 59, 48, 54 };
            CollectionAssert.AreEqual(expectedResult, list);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] list = new int[] { 7, 99, 43, 17, 5, 38, 80, 42, 33 };
            obj.QuickSort(list, 0, 3);
            int[] expectedResult = new int[] { 7, 17, 43, 99, 5, 38, 80, 42, 33 };
            CollectionAssert.AreEqual(expectedResult, list);
        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] list = new int[] { 12, 32, 81, 15, 99, 21, 16, 85, 44, 1 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => obj.QuickSort(list, 0, 20));
        }
        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] list = new int[] { 88, 43, 5, 95, 47, 50, 14, 63, 44, 67, 86 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => obj.QuickSort(list, -1, 10));
        }
        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] list = new int[] { 83, 31, 37, 86, 94, 91, 43, 58, 35, 33, 71, 23 };
            obj.QuickSort(list, 1, 11);
            int[] expectedResult = new int[] { 83, 23, 31, 33, 35, 37, 43, 58, 71, 86, 91, 94 };
            CollectionAssert.AreEqual(expectedResult, list);
        }
    }
}
