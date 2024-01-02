using System.Collections;

class Program
{
	static void Main()
	{
		//Hash
		HashSet<int> myHash1 = new();
		myHash1.Add(2);
		myHash1.Add(6);
		myHash1.Add(1);
		HashSet<int> myHash2 = new();
		myHash2.Add(2);
		myHash2.Add(6);
		myHash2.Add(5);
		myHash1.UnionWith(myHash2);
		myHash1.IntersectWith(myHash2); //out: 2,6
		myHash1.ExceptWith(myHash2); // out: 1
		foreach(int i in myHash1)
		{
			Console.WriteLine(i);
		}
		
	}
}