
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RainbowColors;

namespace RainbowColorsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRed()
        {
            Program program = new Program();
            var rgb = program.GetRgbValue(Color.Red);
            Assert.AreEqual((255, 0, 0), rgb);
        }

        [TestMethod]
        public void TestOrange()
        {
            Program program = new Program();
            var rgb = program.GetRgbValue(Color.Orange);
            Assert.AreEqual((255, 165, 0), rgb);
        }

        [TestMethod]
        public void TestYellow()
        {
            Program program = new Program();
            var rgb = program.GetRgbValue(Color.Yellow);
            Assert.AreEqual((255, 255, 0), rgb);
        }

        [TestMethod]
        public void TestGreen()
        {
            Program program = new Program();
            var rgb = program.GetRgbValue(Color.Green);
            Assert.AreEqual((0, 128, 0), rgb);
        }

        [TestMethod]
        public void TestBlue()
        {
            Program program = new Program();
            var rgb = program.GetRgbValue(Color.Blue);
            Assert.AreEqual((0, 0, 255), rgb);
        }

        [TestMethod]
        public void TestIndigo()
        {
            Program program = new Program();
            var rgb = program.GetRgbValue(Color.Indigo);
            Assert.AreEqual((75, 0, 130), rgb);
        }

        [TestMethod]
        public void TestViolet()
        {
            Program program = new Program();
            var rgb = program.GetRgbValue(Color.Violet);
            Assert.AreEqual((238, 130, 238), rgb);
        }
    }
}
