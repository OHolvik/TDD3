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
            var metodhs = new TDD3_Methods();
            var sentence = "hello hell boy";

            var stringToReplace = "hell";
            var replacementString = "heaven";

            var notExpectedSentence = "heaveno heaven boy";
            var actualSetence = metodhs.StringReplacement(sentence, stringToReplace, replacementString);

            metodhs.StringReplacement(sentence, stringToReplace, replacementString);

            Assert.AreNotEqual(notExpectedSentence, actualSetence);
        }

        [TestMethod()]
        public void StringReplacementTest2()
        {
            var metodhs = new TDD3_Methods();
            var sentence = "Hey how are you?";

            var stringToReplace = "Hey";
            var replacementString = "Hello";

            var expectedSentence = "Hello how are you?";
            var actualSetence = metodhs.StringReplacement(sentence, stringToReplace, replacementString);

            metodhs.StringReplacement(sentence, stringToReplace, replacementString);

            Assert.AreEqual(expectedSentence, actualSetence);
        }

        [TestMethod()]
        public void StringReplacementTest3()
        {
            var metodhs = new TDD3_Methods();
            var sentence = "Hello hey hey";

            var stringToReplace = "hey";
            var replacementString = "bom";

            var expectedSentence = "Hello bom bom";
            var actualSetence = metodhs.StringReplacement(sentence, stringToReplace, replacementString);

            metodhs.StringReplacement(sentence, stringToReplace, replacementString);

            Assert.AreEqual(expectedSentence, actualSetence);
        }
    }
}