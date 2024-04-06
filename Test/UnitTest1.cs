using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammerDayCheck.Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void IsProgrammersDay_WhenDayIs256_ReturnsTrue()
        {
            Func<int, bool> isProgrammersDay = dayOfYear => dayOfYear == 256;

            bool result = isProgrammersDay(256);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsProgrammersDay_WhenDayIsNot256_ReturnsFalse()
        {
            Func<int, bool> isProgrammersDay = dayOfYear => dayOfYear == 256;

            bool result = isProgrammersDay(100);

            Assert.IsFalse(result);
        }
    }
}