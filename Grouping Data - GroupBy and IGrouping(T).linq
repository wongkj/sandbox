<Query Kind="Program" />

void Main()
{
	var people = new List<Person>
	{
		new Person { Name = "Adam", Age = 20 },
		new Person { Name = "Adam", Age = 36 },
		new Person { Name = "Boris", Age = 18 },
		new Person { Name = "Claire", Age = 36 },
		new Person { Name = "Adam", Age = 20 },
		new Person { Name = "Jack", Age = 20 }
	};
	
	// byName1 and byName2 are the same except that byName2 is given the type
	
	var byName1 = people.GroupBy(p => p.Name);				// GroupBy returns the type IGrouping
	IEnumerable<IGrouping<string, Person>> byName2 = people.GroupBy(p => p.Name);
	//Console.WriteLine(byName2);
	
	//Console.WriteLine(people.GroupBy(p => p.Age < 30));		// p.Age < 30 is a Predicate. It returns a boolean value that the OrderBy filters with
	
	var byAgeNames = people.GroupBy(p => p.Age, p => p.Name);
	//Console.WriteLine(byAgeNames);
	
	foreach (var item in byAgeNames)
	{
		Console.WriteLine($"These people are {item.Key} years old");
		
		foreach (var name in item)
		{
			Console.WriteLine($" - {name}");
		}
	}
}

// Define other methods and classes here

class Person
{
	public string Name;
	public int Age;
}