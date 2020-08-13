using System.Collections.Generic;
using System;

namespace ScrabbleScorer 
{
    public class ScrabbleSetScore 
    {
        //props
        public string UserWord { get; set; }
        public static Dictionary<char, int> scrabbleSet = new Dictionary<char, int> () 
        { 
            { 'a', 1 },  { 'b', 3 },  { 'c', 3 },  { 'd', 2 },  { 'e', 1 },  { 'f', 4 },  { 'g', 2 },  { 'h', 4 },  { 'i', 1 },  { 'j', 8 },  { 'k', 5 },  { 'l', 1 },  { 'm', 3 },  { 'n', 1 },  { 'o', 1 },  { 'p', 3 },  { 'q', 10 },  { 'r', 1 },  { 's', 1 },  { 't', 1 },  { 'u', 1 },  { 'v', 4 },  { 'w', 4 },  { 'x', 8 },  { 'y', 4 },  { 'z', 10 }, 
        };
        
        //constructor
        public ScrabbleSetScore(string userWord)
        {
            UserWord = userWord;
        }

        //methods
        public int WordTotal()
        {
            int total = 0;

            if (CheckIfAlphabetical())
            {
                foreach (char letter in UserWord)
                {
                    total += LetterScore(letter);
                }
            }
            else
            {
                Console.WriteLine("This is scrabble, Why the numbers?");
            }
            return total;
        }

        public int LetterScore(char letter)
        {
            return scrabbleSet[letter];
        }
        
        public bool CheckIfAlphabetical()
        {
            foreach (char symbol in UserWord)
            {
                if (!Char.IsLetter(symbol))
                {
                    return false;  
                }
            }
            return true;
        }
    }
}