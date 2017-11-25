<Query Kind="Statements" />


var a = Enumerable.Range(1,10).Select(x => x).ToArray();

var b = new Func<IEnumerable<int>, string>(values =>{ return string.Join(",", values.Select(v => v.ToString()).ToArray());});

Console.WriteLine(b(a));


