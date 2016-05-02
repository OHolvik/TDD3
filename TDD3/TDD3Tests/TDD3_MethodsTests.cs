using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD3.Tests
{
    [TestClass()]
    public class TDD3_MethodsTests
    {
        [TestMethod()]
        public void CountVowelsAndConsonantsTest1()
        {
            var methods = new TDD3_Methods();
            var sentence = "abcdefghij";


            var expectedVowelsCount = 3;
            var expectedConsonantsCount = 7;

            int actualVowelsCount;
            int actualConsonantsCount;

            methods.CountVowelsAndConsonants(sentence, out actualVowelsCount, out actualConsonantsCount);

            Assert.AreEqual(expectedVowelsCount, actualVowelsCount);
            Assert.AreEqual(expectedConsonantsCount, actualConsonantsCount);
        }

        [TestMethod()]
        public void CountVowelsAndConsonantsTest2()
        {

        }

        [TestMethod()]
        public void CountVowelsAndConsonantsTest3()
        {

        }

        [TestMethod()]
        public void StringReplacementTest1()
        {

        }

        [TestMethod()]
        public void StringReplacementTest2()
        {

        }

        [TestMethod()]
        public void StringReplacementTest3()
        {

        }
    }
}