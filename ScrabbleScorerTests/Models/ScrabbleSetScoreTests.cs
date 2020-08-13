using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer;

namespace ScrabbleScorerTests {
    [TestClass]
    public class ScrabbleSetScoreTests {
        // Test methods go here
        [TestMethod]
        public void LetterValue_AllLettersReturnValue_Int() 
        {
            // Arrange
            char letter = 'g';
            ScrabbleSetScore newScore = new ScrabbleSetScore(letter);
            // Act
            int result = newScore.LetterScore(letter);
            // Assert
            Assert.AreEqual(2, result);
        }

        // [TestMethod]
        // public void InputtedWord_IdentifysWords_String()
        // {
        //     // any necessary logic to prep for test; instantiating new classes, etc.
        //     // Assert.AreEqual (EXPECTED RESULT, CODE TO TEST);
        // }

        // [TestMethod]
        // public void WordNumberValue_WordsTotalValue_Int()
        // {
        //     // any necessary logic to prep for test; instantiating new classes, etc.
        //     // Assert.AreEqual (EXPECTED RESULT, CODE TO TEST);
        // }

        // [TestMethod]
        // public void NotAWord_NumbersAndSentencesDontWork_True()
        // {
        //     // any necessary logic to prep for test; instantiating new classes, etc.
        //     // Assert.AreEqual (EXPECTED RESULT, CODE TO TEST);
        // }
    }
}