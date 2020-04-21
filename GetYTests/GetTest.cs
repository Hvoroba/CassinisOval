using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetYTests
{
    [TestClass]
    public class GetTest
    {
        [TestMethod]
        public void GetYTestZeroes()
        {
            double x = 0;
            double a = 0;
            double c = 0;

            double expected = 0;
            double actual = CassOval.GetValues.GetY(x, a, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetYTestOneZeroOne()
        {
            double x = 1;
            double a = 0;
            double c = 1;

            double expected = 0;
            double actual = CassOval.GetValues.GetY(x, a, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetYTestZeroTwoZero()
        {
            double x = 0;
            double a = 2;
            double c = 0;

            double expected = 2;
            double actual = CassOval.GetValues.GetY(x, a, c);

            Assert.AreEqual(expected, actual);
        }
    }
}
