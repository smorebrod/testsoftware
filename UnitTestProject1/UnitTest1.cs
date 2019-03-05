using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testsoftware;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var stringSToCheck = "mysterious";
            var stringToFind = "y";
            var expectedResult = 1;

            var classUnderTest = new stringUtilities();

            var actualResult = classUnderTest.countOfOcurrance(stringSToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);

           
        }

        [TestMethod]
        public void TestMethod2()
        {
            var stringSToCheck = "mysterious";
            var stringToFind = "s";
            var expectedResult = 2;

            var classUnderTest = new stringUtilities();

            var actualResult = classUnderTest.countOfOcurrance(stringSToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);


        }

        [TestMethod]
        public void TestCaseInsensitive()
        {
            var stringSToCheck = "mySterious";
            var stringToFind = "s";
            var expectedResult = 2;

            var classUnderTest = new stringUtilities();

            var actualResult = classUnderTest.countOfOcurrance(stringSToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);


        }


        [TestMethod]
        public void TestHandleNull()
        {
            string stringSToCheck = null;
            var stringToFind = "s";
            var expectedResult = -1;

            var classUnderTest = new stringUtilities();

            var actualResult = classUnderTest.countOfOcurrance(stringSToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
