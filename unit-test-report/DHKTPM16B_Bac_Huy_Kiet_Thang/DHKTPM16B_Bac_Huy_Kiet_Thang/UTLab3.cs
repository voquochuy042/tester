using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UTLab3
{
    [TestClass]
    public class UTLab3
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\dataLab3.csv", "dataLab3#csv", DataAccessMethod.Sequential)]
        [DeploymentItem("dataLab3.csv")]
        [TestMethod]
        public void TestAllMethod()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();
            int chiSoCu = Int32.Parse(TestContext.DataRow[0].ToString());
            int chiSoMoi = Int32.Parse(TestContext.DataRow[1].ToString());
            double actual = method.TinhTienDien(chiSoCu, chiSoMoi);
            double expected = Double.Parse(TestContext.DataRow[2].ToString());
            Assert.AreEqual(expected, actual, 0.001);
        }


    }
}
