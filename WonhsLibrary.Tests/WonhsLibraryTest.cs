using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace WonhsLibrary.Tests
{
    [TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void SelectionSortTest()
        {
            int[] data = { 88, 33, 55, 11 };

            int[] results = WonhsLibrary.Test.Library.SelectionSort(data);

            Assert.AreEqual(11, results[0]);
            Assert.AreEqual(88, results[results.Length-1]);

        }
    }
}
