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
            var sentence = "a1b2c3d4e 5f6g7h8i9j";


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
            var methods = new TDD3_Methods();
            var sentence = "a1b2c3d4e 5f6g7å8ä9ö";


            var expectedVowelsCount = 5;
            var expectedConsonantsCount = 5;

            int actualVowelsCount;
            int actualConsonantsCount;

            methods.CountVowelsAndConsonants(sentence, out actualVowelsCount, out actualConsonantsCount);

            Assert.AreEqual(expectedVowelsCount, actualVowelsCount);
            Assert.AreEqual(expectedConsonantsCount, actualConsonantsCount);
        }

        [TestMethod()]
        public void CountVowelsAndConsonantsTest3()
        {
            var methods = new TDD3_Methods();
            var sentence = "A1B2c3d4e 5f6g7å8ä9ö";


            var expectedVowelsCount = 5;
            var expectedConsonantsCount = 5;

            int actualVowelsCount;
            int actualConsonantsCount;

            methods.CountVowelsAndConsonants(sentence, out actualVowelsCount, out actualConsonantsCount);

            Assert.AreEqual(expectedVowelsCount, actualVowelsCount);
            Assert.AreEqual(expectedConsonantsCount, actualConsonantsCount);
        }

        [TestMethod()]
        public void StringReplacementTest1()
        {
            //Arrenge
            var methods = new TDD3_Methods();
            var sentence = "Hej jag är en åsna";

            var replace = "åsna";
            var replacement = "Jackass";

            //Act
            methods.StringReplacement(sentence,replace, replacement );

            //Assert
            string actual
            Assert.AreNotEqual();

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