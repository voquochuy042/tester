using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UTLab1
{
    [TestClass]
    public class UTLab1
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\dataLab1.csv", "dataLab1#csv", DataAccessMethod.Sequential)]
        [DeploymentItem("dataLab1.csv")]
        [TestMethod]
        public void TestAllMethod()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int a = Int32.Parse(TestContext.DataRow[0].ToString());
            int b = Int32.Parse(TestContext.DataRow[1].ToString());
            int c = Int32.Parse(TestContext.DataRow[2].ToString());

            string expectedResultString = TestContext.DataRow[3].ToString();// Lấy giá trị expectedResult ban đầu là chuỗi

            if (Int32.TryParse(expectedResultString, out int expectedResult))// thử chuyển expectedResult sang số
            { //nếu thành công ,expectedResult là số
                int actualResult = obj.Max(a, b, c);
                Assert.AreEqual(expectedResult, actualResult);
            }
            else //nếu không thành công, expectedResult là chuỗi (là Exception)
            {
                Exception actualResultException = null;
                Exception expectedResultException = new IndexOutOfRangeException();
                try
                {
                    int actualResult = obj.Max(a, b, c);
                }
                catch (Exception ex)
                {
                    actualResultException = ex;
                }
                Assert.AreEqual(expectedResultException.Message, actualResultException.Message);
            }

        }
    }
}
