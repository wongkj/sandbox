<Query Kind="Statements" />

var numbers = new[]{3, 3, 2, 2, 1, 1, 2, 2, 3, 3};

// SKIP
// Skips a specified number of elements

// Console.WriteLine(numbers.Skip(2));

// TAKE
// Puts a limit on the maximum number of items you can take out of the sequence
// There's no problem in trying to take more items than there is available. It won't result in an Exception

// Console.WriteLine(numbers.Skip(2).Take(6));

// SKIP WHILE
// Skips elements while a condition holds true
// The SkipWhile ends the moment the condtion is FALSE. If the condition is false at the 
// start of the loop then it stops the loop immediately.

Console.WriteLine(numbers.SkipWhile(i => i == 3));

// TAKE WHILE
// Take the numbers while a certain condition holds
// TakeWhile ends the moment the condition holds False

Console.WriteLine(numbers.TakeWhile(i => i > 1));






