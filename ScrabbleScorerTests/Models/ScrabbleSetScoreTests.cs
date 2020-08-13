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
            string letter = "g";
            ScrabbleSetScore newScore = new ScrabbleSetScore(letter);
            // Act
            int result = newScore.LetterScore(letter);
            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void InputtedNonAlphabetical_RejectInputtedNonAlphabetical_String()
        {
            // Arrange
            string number = "15";
            ScrabbleSetScore newScore = new ScrabbleSetScore(number);

            // Act
            string result = newScore.CheckIfAlphabetical(number);

            // Assert
            Assert.AreEqual ("This is scrabble, Why the number?", result);
        }

        [TestMethod]
        public void InputtedAlphabetical_AcceptedInputtedAlphabetical_String()
        {
            // Arrange
            string letters = "yes";
            ScrabbleSetScore newScore = new ScrabbleSetScore(letters);

            // Act
            string result = newScore.CheckIfAlphabetical(letters);

            // Assert
            Assert.AreEqual("OK", result);
        }

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