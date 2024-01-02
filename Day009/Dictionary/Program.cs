using System.Collections;

class Program
{
	static void Main()
	{	
		//Dictionary 
		Dictionary<int,string> myDictionary = new();
		myDictionary.Add(5,"satu");
		myDictionary.Add(2,"dua");
		// foreach(KeyValuePair<int,string> kvp in myDictionary)
		// {
		// 	Console.WriteLine(kvp.Key);
		// 	Console.WriteLine(kvp.Value);
		// }
		//SHORT BY KEY
		foreach(var kvp in myDictionary.OrderByDescending(x => x.Key))
		{
			Console.WriteLine(kvp);
		}
		// foreach(string kvp in myDictionary.Values)
		// {
		// 	Console.WriteLine(kvp);
		// }
		// Console.WriteLine(myDictionary.ContainsKey(2));
	}
}