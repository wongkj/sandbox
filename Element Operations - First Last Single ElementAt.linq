<Query Kind="Statements" />

var numbers = new List<int>{1, 2, 3};

//************************
// FIRST
//************************

// Getting the first element in a Collection

Console.WriteLine("The First element in the Collection is " + numbers.First());

//************************
// FIRST WITH PREDICATE
//************************

// Getting the first element that satisfies a particular predicate
// You need to provide a lambda

Console.WriteLine("The First element in the Collection that is larger than 2 is " + numbers.First(x => x > 2));

//************************
// FIRST WITH EXCEPTION
//************************

// The following will result in an Exception because there is no element in the Collection 
// with a value greater than 10

// Console.WriteLine("The First element larger than 2 is " + numbers.First(x => x > 10));

//************************
// FIRSTORDEFAULT
//************************

// To get around the above exception problem is to set a default value of the 'Collection Type' 
// if the predicate responds with an Exception. Since this is a Collection of Integers, the 
// default value is 0

Console.WriteLine("The First element larger than 2 is " + numbers.FirstOrDefault(x => x > 10));


//************************
// LAST
//************************

// Getting the last element in a Collection

Console.WriteLine("The last element in the Collection is " + numbers.Last());

//************************
// LAST WITH PREDICATE
//************************

// Getting the Last element that satisfies a particular predicate
// You need to provide a lambda

Console.WriteLine("The last element in the Collection that is less than 3 is " + numbers.Last(x => x < 3));

//************************
// SINGLE
//************************

// Returns the value of a Collection that has only a single value in it.
// If the Collection has more than 1 element then an Exception is thrown

Console.WriteLine("The single value in this Collection is " + new int[]{123}.Single());


//************************
// SINGLE OR DEFAULT
//************************

// To get around the above exception problem is to set a default value of the 'Collection Type' 
// if the predicate responds with an Exception. Since this is a Collection of Integers, the 
// default value is 0 BUT ONLY IF THE COLLECTION HAS ZERO ELEMENTS. If the Collection has
// more than 1 element an Exception will still be thrown.

Console.WriteLine("The single value in this Collection is " + new int[]{}.SingleOrDefault());


//************************
// ELEMENTAT
//************************

// ElementAt is not a cheap Operator. It consumes a bit of memory, so if you 
// already know what the Collection type is that you are searching through
// it is probably best to use the index of that Collection, such as 
// List<int> num = new List<int> {1,2,3};
// numbers[2];

Console.WriteLine("Item at position 1: " + numbers.ElementAt(1));

Console.WriteLine("Item at position 4: " + numbers.ElementAtOrDefault(4));
















