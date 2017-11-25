<Query Kind="Statements" />

var numbers = Enumerable.Range(1,4);
var squares = numbers.Select(x => x*x);		//map
//Console.WriteLine(squares);

string sentence = "This is a nice sentence";
var wordLengths = sentence.Split().Select(w => w.Length);
//Console.WriteLine(wordLengths);

var wordsWithLength = sentence.Split().Select(w => new {Word = w, Size = w.Length});
//Console.WriteLine(wordsWithLength);


Random rand = new Random();
// Create an Enumerable Range of 10 values then discard them and replace them with Random numbers.
var randomNumbers = Enumerable.Range(1,10).Select(_ => rand.Next(10));
//Console.WriteLine(randomNumbers);


// Use SelectMany when you have a collection of objects which itself is made up of a collection of objects.
// You Use SelectMany to flatten the collection and then create your array based on that flattened collection.
var sequences = new[] {"red,green,blue", "orange", "white,pink"};
var allWords = sequences.SelectMany(s => s.Split(','));
//Console.WriteLine(allWords);


var fancy = sentence.Split().Select( word => new {Word = word, Length = word.Length, Uppercase = word.ToUpper()});
//Console.WriteLine(fancy);

string[] objects = {"house","car","bicycle"};
string[] colors = {"red","green","gray"};

// Performing a CROSS SelectMany


// CARTESIAN PRODUCT / PAIR WISE CONSTRUCTION

// Creating a string of matching pairs
var pairs1 = colors.SelectMany(_ => objects, (c, o) => $"{c} {o}");
// Creating a table of the matching pairs using an Anonymous Method
var pairs2 = colors.SelectMany(_ => objects, (c, o) => new {Color = c, Obj = o});
Console.WriteLine(pairs2);