<Query Kind="Statements" />


var numbers = Enumerable.Range(1,10);
var evenNumbers = numbers.Where(x => x % 2 == 0).Select(y => y*y).Where(z => z < 50);

Console.WriteLine(evenNumbers);