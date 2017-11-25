<Query Kind="Program" />

void Main()
{
	Random rand = new Random();
	
	var randomValues = Enumerable.Range(1,10)
		.Select(_ => rand.Next(10)-5).ToArray();
	
	var csvString = new Func<IEnumerable<int>, string>(values =>
	{
		return string.Join(",", values.Select(v => v.ToString()).ToArray());
	});
	
	Console.WriteLine(csvString(randomValues));
	Console.WriteLine(csvString(randomValues.OrderBy(x => x)));
	Console.WriteLine(csvString(randomValues.OrderByDescending(x => x)));
	
	var people = new List<Person>
	{
		new Person { Name = "Adam", Age = 36 },
		new Person { Name = "Boris", Age = 18 },
		new Person { Name = "Claire", Age = 36 },
		new Person { Name = "Adam", Age = 20 },
		new Person { Name = "Jack", Age = 20 }
	};
	
	// The output of an OrderBy is not an IEnumerable. 
	// It is an IOrderedEnumerable
	
	IOrderedEnumerable<Person> sortedPeople = people.OrderBy(p => p.Name);
	//Console.WriteLine(people.OrderBy(p => p.Name));
	//Console.WriteLine(sortedPeople);
	Console.WriteLine(people.OrderBy(p => p.Age)
							.ThenByDescending(p => p.Name));	// OrderBy() Returns an IOrderedEnumerable<#variable>
							
	// Reversing a String of Text
	
	string s = "This is a test";
	Console.WriteLine(new string(s.Reverse().ToArray()));		// Reverse() Returns an IEnumerable<char>
	
}

// Define other methods and classes here

class Person
{
	public string Name;
	public int Age;
	
}