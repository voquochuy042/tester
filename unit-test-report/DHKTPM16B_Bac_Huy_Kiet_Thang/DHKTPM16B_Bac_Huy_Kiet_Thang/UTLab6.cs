using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTLab6
{
    [TestClass]
    public class UTLab6
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\dataLab6.csv", "dataLab6#csv", DataAccessMethod.Sequential)]
        [DeploymentItem("dataLab6.csv")]
        [TestMethod]
        public void TestAllMethod()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();
            string s1 = TestContext.DataRow[0].ToString();
            string s2 = TestContext.DataRow[1].ToString();
            string s3 = TestContext.DataRow[2].ToString();
            string expected = TestContext.DataRow[3].ToString();
            string actual = method.ThayThe(s1, s2, s3);
            Assert.AreEqual(expected, actual);
        }

    }
}
