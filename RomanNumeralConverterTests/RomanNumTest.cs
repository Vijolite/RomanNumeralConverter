using RomanNumeralConverterLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace RomanNumeralConverterTests
{
    [TestClass]
    public class RomanNumTest
    {
        [TestMethod]
        public void TestConvertTo1()
        {
            RomanNum roman = new RomanNum("I");
            int x = roman.ConvertIntoInt();
            Assert.AreEqual(x, 1);
        }
        [TestMethod]
        public void TestConvertTo2()
        {
            RomanNum roman = new RomanNum("II");
            int x = roman.ConvertIntoInt();
            Assert.AreEqual(x, 2);
        }
        [TestMethod]
        public void TestConvertTo3()
        {
            RomanNum roman = new RomanNum("III");
            int x = roman.ConvertIntoInt();
            Assert.AreEqual(x, 3);
        }
        [TestMethod]
        public void TestConvertTo4()
        {
            RomanNum roman = new RomanNum("IV");
            int x = roman.ConvertIntoInt();
            Assert.AreEqual(x, 4);
        }
        [TestMethod]
        public void TestConvertTo5()
        {
            RomanNum roman = new RomanNum("V");
            int x = roman.ConvertIntoInt();
            Assert.AreEqual(x, 5);
        }
        [TestMethod]
        public void TestConvertTo6()
        {
            RomanNum roman = new RomanNum("VI");
            int x = roman.ConvertIntoInt();
            Assert.AreEqual(x, 6);
        }
        [TestMethod]
        public void TestConvertTo7()
        {
            RomanNum roman = new RomanNum("VII");
            int x = roman.ConvertIntoInt();
            Assert.AreEqual(x, 7);
        }
        [TestMethod]
        public void TestConvertTo8()
        {
            RomanNum roman = new RomanNum("VIII");
            int x = roman.ConvertIntoInt();
            Assert.AreEqual(x, 8);
        }
        [TestMethod]
        public void TestConvertTo9()
        {
            RomanNum roman = new RomanNum("IX");
            int x = roman.ConvertIntoInt();
            Assert.AreEqual(x, 9);
        }
        [TestMethod]
        public void TestConvertTo10()
        {
            RomanNum roman = new RomanNum("X");
            int x = roman.ConvertIntoInt();
            Assert.AreEqual(x, 10);
        }
    }
}