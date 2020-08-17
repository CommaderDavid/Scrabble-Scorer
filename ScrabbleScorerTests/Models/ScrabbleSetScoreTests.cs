using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System;

namespace ScrabbleScorerTests 
{
    [TestClass]
    public class ScrabbleSetScoreTests 
    {
        // Test methods go here
        [TestMethod]
        public void LetterValue_AllLettersReturnValue_Int() 
        {
            // Arrange
            string letter = "g";
            ScrabbleSetScore newScore = new ScrabbleSetScore(letter);
            // Act
            int result = newScore.LetterScore(Convert.ToChar(letter));
            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void InputtedNonAlphabetical_RejectInputtedNonAlphabetical_bool()
        {
            // Arrange
            string number = "15";
            ScrabbleSetScore newScore = new ScrabbleSetScore(number);

            // Act
            bool result = newScore.CheckIfAlphabetical();

            // Assert
            Assert.AreEqual (false, result);
        }

        [TestMethod]
        public void InputtedAlphabetical_AcceptedInputtedAlphabetical_Bool()
        {
            // Arrange
            string letters = "yes";
            ScrabbleSetScore newScore = new ScrabbleSetScore(letters);

            // Act
            bool result = newScore.CheckIfAlphabetical();

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void WordTotal_ReturnsAWordsTotalValue_Int()
        {
            // Arrange
            string letters = "total";
            ScrabbleSetScore newScore = new ScrabbleSetScore(letters);

            // Act
            int result = newScore.WordTotal();

            // Assert
            Assert.AreEqual (5, result);
        }

        [TestMethod]
        public void WordTotal_RejectsANonWord_Int()
        {
            // Arrange
            string letters = "8008";
            ScrabbleSetScore newScore = new ScrabbleSetScore(letters);

            // Act
            int result = newScore.WordTotal();

            // Assert
            Assert.AreEqual (0, result);
        }

        [TestMethod]
        public void WordTotal_RejectsMultibleWords_Int()
        {
            // Arrange
            string letters = "poopy mcpants";
            ScrabbleSetScore newScore = new ScrabbleSetScore(letters);

            // Act
            int result = newScore.WordTotal();

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}