<Query Kind="Statements" />

var arr1 = new[] {1, 2, 3};
var arr2 = new[] {1, 2, 3};


// These 2 equality operations will result in FALSE because
// they are referential equality operators and both variable
// refer to different objects. These operators don't compare 
// the content in the variables

Console.WriteLine(arr1 == arr2);
Console.WriteLine(arr1.Equals(arr2));

// SEQUENCEEQUAL
// This LINQ function compares the content of the variables
// to see if they are equal

Console.WriteLine(arr1.SequenceEqual(arr2));

// SequenceEqual can also compare the content of the variables
// irregardless of what type the variables are. In the below
// case is a comparison between the content of a list and an
// array

var list1 = new List<int>{1, 2, 3};
Console.WriteLine(arr1.SequenceEqual(list1));






