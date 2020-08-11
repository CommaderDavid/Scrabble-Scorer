using System.Collections.Generic;

namespace ScrabbleScorer {
    public class ScrabbleSetScore {
        // properties, constructors, methods, etc. go here
        // create arrays to hold the letters, then directory to assign them a corisponding number
        Dictionary<string, int> myDictionary = new Dictionary<string, int> () { { "A", 1 }, { "B", 1 } };
        string[] ones = {"a", "e", "i", "o", "u", "l", "n", "r", "s", "t"};
        string[] twos = {"d", "g"};
        string[] threes = {"b", "c", "m", "p"};
        string[] fours = {"f", "h", "v", "w", "y"};
        string[] fives = {"k"};
        string[] eights = {"j", "x"};
        string[] tens = {"q", "z"};
    }
}