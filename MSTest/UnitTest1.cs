using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DuplicateCheckNameSpace;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DuplicateCheckOnGivenMethod()
        {
            var originalString = "[a],[d],[b],[ab],[c],[d],[d],[ce],[ef],[ef],[b]";
            List<string> originalList = new List<string>();
            originalList.AddRange(originalString.Split(','));
            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates
            Assert.AreEqual(3, duplicates.Count);
            Assert.IsTrue(duplicates.Contains("[d]"));
            Assert.IsTrue(duplicates.Contains("[ef]"));
            Assert.IsTrue(duplicates.Contains("[b]"));
        }
        [TestMethod]
        public void DuplicateCheckOn1000StringsList()
        {
            var originalList = new List<string>();
            for (int i = 0; i < 1000; i++)
                originalList.Add(DuplicateCheck.RandomString(3));
            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates
            Assert.AreEqual(1000, originalList.Count);
            Assert.IsTrue(duplicates.Count > 0);
        }
        [TestMethod]
        public void NoItemDuplicateCheck() {
            var originalString = "";
            List<string> originalList = new List<string>();
            originalList.AddRange(originalString.Split(','));
            List<string> duplicates = originalList.GetDuplicates();
            Assert.AreEqual(0, duplicates.Count);
        }
    }
}
