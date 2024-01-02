using System.Collections;

class Program
{
	static void Main()
	{	
		//Dictionary 
		Dictionary<int,string> myDictionary = new();
		myDictionary.Add(1,"satu");
		myDictionary.Add(2,"dua");
		// foreach(KeyValuePair<int,string> kvp in myDictionary)
		// {
		// 	Console.WriteLine(kvp.Key);
		// 	Console.WriteLine(kvp.Value);
		// }
		// foreach(int kvp in myDictionary.Keys)
		// {
		// 	Console.WriteLine(kvp);
		// }
		foreach(string kvp in myDictionary.Values)
		{
			Console.WriteLine(kvp);
		}
		Console.WriteLine(myDictionary.ContainsKey(2));
		
	}
}