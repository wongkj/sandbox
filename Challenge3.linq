<Query Kind="Program" />

void Main()
{
	int[] input = {-3, -1, 3, 7, 1, -3, 7};
	
	Console.WriteLine(input.SkipWhile(i => i < 0).TakeWhile(j => j > 0).Count());
	
}

// Define other methods and classes here
