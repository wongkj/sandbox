<Query Kind="Statements" />


int[] numbers = {1, 2, 3, 4, 5};

// ALL
// Requires that every element satisfies the predicate

Console.WriteLine("Are all numbers > 0? " +
		numbers.All(x => x > 0));
Console.WriteLine("Are all numbers > 0? " +
		numbers.All(x => x % 2 == 1));
		
// ANY
// Requires that at least one element satisfies the predicate

Console.WriteLine("Any number < 2 ? " +
		numbers.Any(x => x < 2));

// Any does not require any arguments. Any can be used to check if a Collection has zero elements in it.

Console.WriteLine("Does this array have any elements?  " + new int[]{}.Any());

// CONTAINS
// Checks to see if a Collection has a certain value.

Console.WriteLine("Contains 5? " + numbers.Contains(5));
