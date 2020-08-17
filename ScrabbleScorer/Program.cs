using System.Collections.Generic;
using System;
using ScrabbleScorer.Models;

// Fisrt is namespace
namespace ScrabbleScorer
{
    // Second is Class
    public class Program
    {
        //Third is method
        public static void Main()
        {
            Console.WriteLine("Welcome to the Scrabble scorer!");

            Console.WriteLine("Enter one word you like to get a score for:");
            string enteredWord = Console.ReadLine().ToLower();

            ScrabbleSetScore userWord = new ScrabbleSetScore(enteredWord);

            int result = userWord.WordTotal();
            Console.WriteLine(result);
        }
    }
}