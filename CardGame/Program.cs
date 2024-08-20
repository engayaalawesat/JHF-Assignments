using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<(string rank, string suit)> cards = new List<(string rank, string suit)>
        {
            ("A", "h"), ("2", "h"), ("3", "h"), ("4", "h"), ("5", "h"), ("6", "h"),
            ("7", "h"), ("8", "h"), ("9", "h"), ("10", "h"), ("J", "h"), ("Q", "h"), ("K", "h"),
            ("A", "d"), ("2", "d"), ("3", "d"), ("4", "d"), ("5", "d"), ("6", "d"),
            ("7", "d"), ("8", "d"), ("9", "d"), ("10", "d"), ("J", "d"), ("Q", "d"), ("K", "d"),
            ("A", "c"), ("2", "c"), ("3", "c"), ("4", "c"), ("5", "c"), ("6", "c"),
            ("7", "c"), ("8", "c"), ("9", "c"), ("10", "c"), ("J", "c"), ("Q", "c"), ("K", "c"),
            ("A", "s"), ("2", "s"), ("3", "s"), ("4", "s"), ("5", "s"), ("6", "s"),
            ("7", "s"), ("8", "s"), ("9", "s"), ("10", "s"), ("J", "s"), ("Q", "s"), ("K", "s")
        };

        // Dictionary to count the number of unique cards for each suit
        var suitCounts = new Dictionary<string, HashSet<string>>()
        {
            { "h", new HashSet<string>() },  // Hearts
            { "d", new HashSet<string>() },  // Diamonds
            { "c", new HashSet<string>() },  // Clubs
            { "s", new HashSet<string>() }   // Spades
        };

        // Add ranks to respective suit's HashSet
        foreach (var card in cards)
        {
            suitCounts[card.suit].Add(card.rank);
        }

        // Find the minimum number of unique cards in any suit
        // Each full set requires 13 unique cards per suit
        int result = suitCounts.Min(suit => suit.Value.Count) / 13;

        // Print the result
        Console.WriteLine(result);

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
