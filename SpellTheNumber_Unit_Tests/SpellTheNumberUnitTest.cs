using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spell_The_Number;
namespace SpellTheNumber_Unit_Tests
{
    [TestClass]
    public class SpellTheNumberUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void Number_Hundred_Series_TestMethod()
        {
            var translated = new SpellTheNumber();
            var actualResult = translated.ConvertToWords("123");
            var expectedResult = "One Hundred And Twenty Three";
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Number_Thousand_Series_TestMethod()
        {
            var translated = new SpellTheNumber();
            var actualResult = translated.ConvertToWords("13456");
            var expectedResult = "Thirteen Thousand Four Hundred And Fifty Six";
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Number_Million_Series_TestMethod()
        {
            var translated = new SpellTheNumber();
            var actualResult = translated.ConvertToWords("1233456");
            var expectedResult = "One Million Two Hundred Thirty Three Thousand Four Hundred And Fifty Six";
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Number_Billion_Series_TestMethod()
        {
            var translated = new SpellTheNumber();
            var actualResult = translated.ConvertToWords("1233445566");
            var expectedResult = "One Billion Two Hundred Thirty Three Million Four Hundred Fourty Five Thousand Five Hundred And Sixty Six";
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        [ExpectedException (typeof(NullReferenceException))]
        public void Number_Exception_TestMethod()
        {
            var translated = new SpellTheNumber();
            var actualResult = translated.ConvertToWords("134.56");
            
        }
    }
}
