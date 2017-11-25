<Query Kind="Statements" />

var numbers = Enumerable.Range(1,10);
var evenNumbers = numbers.Where(n => n % 2 == 0);
//Console.WriteLine(evenNumbers);

var oddSquares = numbers.Select(x => x*x).Where(y => y % 2 == 1);
//Console.WriteLine(oddSquares);

object[] values = {1, 2.5, 3, 4.56};
Console.WriteLine(values.OfType<int>());