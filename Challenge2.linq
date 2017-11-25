<Query Kind="Program" />

void Main()
{
	var a = new int[] {1, 2, 3, 4, 5};
	var b = new int[] {1, 3, 5, 7, 9};

	Console.WriteLine(a.Except(b).Union(b.Except(a)));
	
	
}

//public static IEnumerable<int> Merge(IEnumerable<int> a, IEnumerable<int> b)
//{
	
//}

// Define other methods and classes here
