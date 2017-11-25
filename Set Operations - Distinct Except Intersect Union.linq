<Query Kind="Statements" />



string word1 = "helloooo";
string word2 = "hellp";

// DISTINCT

Console.WriteLine(word1.Distinct());

// INTERSECTION
// letters found in both string variables

var lettersInBothWords = word1.Intersect(word2);
Console.WriteLine(lettersInBothWords);

// UNION
// Getting the unique collection of both string variables

Console.WriteLine(word1.Union(word2));

// EXCEPT
// Get all letters in one collection that is not in the other collection
// Get all the letters in word1 that are not in word2

Console.WriteLine(word1.Except(word2));
