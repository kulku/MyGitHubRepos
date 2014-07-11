using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LceUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDivisibleBy3()
        {
            //initialize
            LceLibrary.Lce lce = new LceLibrary.Lce();
            List<int> inputList = new List<int> { 3, 6, 9 };
            String actual;
            String expected = "fizz";

            inputList.ForEach(i =>
            {  //Act
                actual = lce.ProcessLceForOneInt(i);

                //Assert/Verify
                Assert.AreEqual<String>(expected, actual, "DivisibleBy3");
            });
           
        }
        [TestMethod]
        public void TestDivisibleBy5()
        {
            //initialize
            LceLibrary.Lce lce = new LceLibrary.Lce();
            List<int> inputList = new List<int> { 5, 10, 20 }; // Not 15
            String actual;
            String expected = "buzz";
            inputList.ForEach(i => {
                //Act
                actual = lce.ProcessLceForOneInt(i);

                //Assert/Verify
                Assert.AreEqual<String>(expected, actual, "DivisibleBy5");
            });
           
        }
        [TestMethod]
        public void TestDivisibleBy3And5()
        {
            //initialize
            LceLibrary.Lce lce = new LceLibrary.Lce();
            List<int> inputList = new List<int> { 15, 30, 45 };
            String actual;
            String expected = "fizzbuzz";

            inputList.ForEach(i => {
                //Act
                actual = lce.ProcessLceForOneInt(i);

                //Assert/Verify
                Assert.AreEqual<String>(expected, actual, "DivisibleBy3And5");
            });
            
        }
        [TestMethod]
        public void TestNotDivisibleBy3And5()
        {
            //initialize
            LceLibrary.Lce lce = new LceLibrary.Lce();
            List<int> inputList = new List<int> { 1, 2, 4 };
            String actual;
            String expected = String.Empty;

            inputList.ForEach(i =>
            {
                //Act
                actual = lce.ProcessLceForOneInt(i);
                expected = i.ToString();

                //Assert/Verify
                Assert.AreEqual<String>(expected, actual, "DivisibleBy3And5");
            });
        }
        [TestMethod]
        public void TestConfigurableRules()
        {
            //initialize
            LceLibrary.Lce lce = new LceLibrary.Lce();
            List<int> inputList = new List<int> { 2, 4 };
            Dictionary<int, String> rules = new Dictionary<int, string>() { {2, "TestD2"}, {3, "TestD3"} };
            String actual;
            String expected = "TestD2";

            inputList.ForEach(i =>
            {
                //Act
                actual = lce.ProcessLceForOneInt(rules, i);

                //Assert/Verify
                Assert.AreEqual<String>(expected, actual, "ConfigurableRules");
            });
        }
    }
}
