<Query Kind="Statements" />


var numbers = Enumerable.Range(1,10);

//Console.WriteLine(numbers);

//*************************
// AGGREGATE
//*************************

// Aggregate performs whatever the expression specifies on each individual element
// in the Collection until there are no more elements in the collection.

// SUM

// 1 + 2 = 3
// 3 + 3 = 6
// 6 + 4 = 10
// etc.....

Console.WriteLine("Sum = " + 
		numbers.Aggregate((p,x) => p + x));

// PRODUCT

// The product performs the multiplication on a seed element and then
// multiplies the resulting product values against each other.
// The seed below is the number 1

Console.WriteLine("Product = " +
		numbers.Aggregate(1, (p, x) => p * x));



// SUBSEQUENT LINQ OPERATORS

// Linq has operators that perform essentially the same function as the Aggregates
// listed above.

// SUM

Console.WriteLine("Sum = " + numbers.Sum());
Console.WriteLine("Average = " + numbers.Average());

// AGGREGATE - WORKING WITH STRINGS

var words = new[] { "one", "two", "three" };

Console.WriteLine(words.Aggregate((p,x) => p + "," + x));

// AGGREGATE - WORKING WITH STRINGS WITH A SEED VALUE

Console.WriteLine(words.Aggregate("hello",(p,x) => p + "," + x));

// COUNT
// Count is also an Aggregation

Console.WriteLine("We have " + numbers.Count() + " elements");
















