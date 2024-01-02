using System.Collections;

class Program
{
	static void Main()
	{
		List
		List<int> myList = new();
		myList.Add(2);
		myList.Add(4);
		myList.Add(5);
		string a = myList[1].ToString();
		string b = myList[2].ToString();
		string c = b+a;
		Console.WriteLine(c);
		myList.ForEach(i => Console.Write("{0}\t", i));
		
		
	}
}