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

        [TestCase("I",1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        public void TestConvertRomanToInt(string romanVal, int result)
        {
            RomanNum roman = new RomanNum(romanVal);
            roman.ConvertIntoInt().Should().Be(result);
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
        [TestMethod]
        public void TestConvertTo3005()
        {
            RomanNum roman = new RomanNum("MMMDV");
            int x = roman.ConvertIntoInt();
            x.Should().Be(3505);
        }
        [TestMethod]
        public void TestConvertIntToRoman2000()
        {
            IntNum x = new IntNum(2000);
            string result = x.ConvertIntoRoman();
            result.Should().Be("MM");
        }
        [TestMethod]
        public void TestConvertIntToRoman2700()
        {
            IntNum x = new IntNum(2700);
            string result = x.ConvertIntoRoman();
            result.Should().Be("MMDCC");
        }
        [TestMethod]
        public void TestConvertIntToRoman2780()
        {
            IntNum x = new IntNum(2780);
            string result = x.ConvertIntoRoman();
            result.Should().Be("MMDCCLXXX");
        }
        [TestMethod]
        public void TestConvertIntToRoman2340()
        {
            IntNum x = new IntNum(2340);
            string result = x.ConvertIntoRoman();
            result.Should().Be("MMCCCXL");
        }
        [TestMethod]
        public void TestConvertIntToRoman235()
        {
            IntNum x = new IntNum(235);
            string result = x.ConvertIntoRoman();
            result.Should().Be("CCXXXV");
        }
        [TestMethod]
        public void TestConvertIntToRoman17()
        {
            IntNum x = new IntNum(17);
            string result = x.ConvertIntoRoman();
            result.Should().Be("XVII");
        }
        [TestMethod]
        public void TestConvertIntToRoman9()
        {
            IntNum x = new IntNum(9);
            string result = x.ConvertIntoRoman();
            result.Should().Be("IX");
        }
    }
}