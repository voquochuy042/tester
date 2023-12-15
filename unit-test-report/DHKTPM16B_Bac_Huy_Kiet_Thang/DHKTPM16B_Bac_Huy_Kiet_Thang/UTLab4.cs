using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTLab4
{
    [TestClass]
    public class UTLab4
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();
            long s;
            long actual = method.Sum(6, out s);
            long expected1 = 4;
            long expected2 = 10;
            Assert.AreEqual(expected1, actual);
            Assert.AreEqual(expected2,s);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();
            long s;
            long actual = method.Sum(-10, out s);
            long expected1 = 1;
            long expected2 = 1;
            Assert.AreEqual(expected1, actual);
            Assert.AreEqual(expected2, s);
        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();
            long s;
            long actual = method.Sum(1, out s);
            long expected1 = 3;
            long expected2 = 2;
            Assert.AreEqual(expected1, actual);
            Assert.AreEqual(expected2, s);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();
            long s;
            long actual = method.Sum(0, out s);
            long expected1 = 1;
            long expected2 = 1;
            Assert.AreEqual(expected1, actual);
            Assert.AreEqual(expected2, s);
        }
    }
}
