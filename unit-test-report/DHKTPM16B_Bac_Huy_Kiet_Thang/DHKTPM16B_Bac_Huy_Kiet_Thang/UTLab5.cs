using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UTLab5
{
    [TestClass]
    public class UTLab5
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\dataLab5.csv", "dataLab5#csv", DataAccessMethod.Sequential)]
        [DeploymentItem("dataLab5.csv")]
        [TestMethod]
        public void TestAllMethod()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string s = Convert.ToString(TestContext.DataRow[0]);
            int n = Int32.Parse(TestContext.DataRow[1].ToString());
            int p = Int32.Parse(TestContext.DataRow[2].ToString());
            string actualResult = obj.HuyChuoi(s, n, p);
            string expectedResult = Convert.ToString(TestContext.DataRow[3]); ;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
