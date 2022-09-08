using RomanNumeralConverterLibrary;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using FluentAssertions;

namespace RomanNumeralConverterTests
{
    [TestClass]

    public class RomanNumTest
    {

            [TestCase("I")]
            [TestCase("II")]
            [TestCase("III")]
            public void TestIfStringIsRomanNumeral(string value)
            {
                var result = RomanNum.IsRomanNumeral(value);
                Assert.IsTrue(result, $"{value} should be a Roman numeral");
            }

            [TestCase("aa")]
            [TestCase("BB")]
            [TestCase("ccc")]
            [TestCase("")]
            public void TestIfStringIsNotRomanNumeral(string value)
            {
                var result = RomanNum.IsRomanNumeral(value);
                Assert.IsFalse(result, $"{value} should be a Roman numeral, but it is not");
            }

        [TestMethod]
        public void TestConvertTo1()
        {
            RomanNum roman = new RomanNum("I");
            int x = roman.ConvertIntoInt();
            //Assert.AreEqual(x, 1);
            Assert.IsTrue(x==1, "Roman I should be converted into 1");
        }
        [TestMethod]
        public void TestConvertTo2()
        {
            RomanNum roman = new RomanNum("II");
            int x = roman.ConvertIntoInt();
            Assert.IsTrue(x == 2, "Roman II should be converted into 2");
        }
        [TestMethod]
        public void TestConvertTo3()
        {
            RomanNum roman = new RomanNum("III");
            int x = roman.ConvertIntoInt();
            Assert.IsTrue(x == 3, "Roman III should be converted into 3");
        }
        [TestMethod]
        public void TestConvertTo4()
        {
            RomanNum roman = new RomanNum("IV");
            int x = roman.ConvertIntoInt();
            Assert.IsTrue(x == 4, "Roman IV should be converted into 4");
        }
        [TestMethod]
        public void TestConvertTo5()
        {
            RomanNum roman = new RomanNum("V");
            int x = roman.ConvertIntoInt();
            Assert.IsTrue(x == 5, "Roman V should be converted into 5");
        }
        [TestMethod]
        public void TestConvertTo6()
        {
            RomanNum roman = new RomanNum("VI");
            int x = roman.ConvertIntoInt();
            Assert.IsTrue(x == 6, "Roman VI should be converted into 6");
        }
        [TestMethod]
        public void TestConvertTo7()
        {
            RomanNum roman = new RomanNum("VII");
            int x = roman.ConvertIntoInt();
            Assert.IsTrue(x == 7, "Roman VII should be converted into 7");
        }
        [TestMethod]
        public void TestConvertTo8()
        {
            RomanNum roman = new RomanNum("VIII");
            int x = roman.ConvertIntoInt();
            Assert.IsTrue(x == 8, "Roman VIII should be converted into 8");
        }
        [TestMethod]
        public void TestConvertTo9()
        {
            RomanNum roman = new RomanNum("IX");
            int x = roman.ConvertIntoInt();
            Assert.IsTrue(x == 9, "Roman IX should be converted into 9");
        }
        [TestMethod]
        public void TestConvertTo10()
        {
            RomanNum roman = new RomanNum("X");
            int x = roman.ConvertIntoInt();
            Assert.IsTrue(x == 10, "Roman X should be converted into 10");
        }
        [TestMethod]
        public void TestConvertTo11()
        {
            RomanNum roman = new RomanNum("XI");
            int x = roman.ConvertIntoInt();
            x.Should().Be(11);
        }
        [TestMethod]
        public void TestConvertTo34()
        {
            RomanNum roman = new RomanNum("XXXIV");
            int x = roman.ConvertIntoInt();
            x.Should().Be(34);
        }
        [TestMethod]
        public void TestConvertTo63()
        {
            RomanNum roman = new RomanNum("LXIII");
            int x = roman.ConvertIntoInt();
            x.Should().Be(63);
        }
        [TestMethod]
        public void TestConvertTo210()
        {
            RomanNum roman = new RomanNum("CCX");
            int x = roman.ConvertIntoInt();
            x.Should().Be(210);
        }
    }
}