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
        public void Number_Thousand_Series_TestMethod()
        {
            var translated = new SpellTheNumber();
            var actualResult = translated.ConvertToWords("13456");
            var expectedResult = "Thirteen Thousand Four Hundred Fifty Six";
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
