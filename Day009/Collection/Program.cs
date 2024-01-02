using System.Collections;

class Program
{
	static void Main()
	{
		//Array
		// int[] myArray1 = new int[4];
		// Console.WriteLine(myArray1[0]);
		// string[] myArray2 = {"a","b"};
		// Console.WriteLine(myArray2);
		// Console.WriteLine(myArray2[1]);
		
		//ArrayList
		// ArrayList myArrayList = new();
		// myArrayList.Add(3);
		// myArrayList.Add(4);
		// myArrayList.Add(5);
		// Console.WriteLine(myArrayList[0]);
		
		//List
		// List<int> myList = new();
		// myList.Add(2);
		// myList.Add(4);
		// myList.Add(5);
		// string a = myList[1].ToString();
		// string b = myList[2].ToString();
		// string c = b+a;
		// Console.WriteLine(c);
		// myList.ForEach(i => Console.Write("{0}\t", i));
		
		//Hash
		HashSet<int> myHash1 = new();
		// myHash1.Add(2);
		// myHash1.Add(6);
		// myHash1.Add(1);
		// HashSet<int> myHash2 = new();
		// myHash2.Add(2);
		// myHash2.Add(6);
		// myHash2.Add(5);
		//myHash1.UnionWith(myHash2);
		//myHash1.IntersectWith(myHash2); //out: 2,6
		// myHash1.ExceptWith(myHash2); // out: 1
		// foreach(int i in myHash1)
		// {
		// 	Console.WriteLine(i);
		// }
		
		//Queue
		// Queue<int> queue = new();
		// queue.Enqueue(3);
		// queue.Enqueue(4);
		// queue.Enqueue(5);
		// Console.WriteLine(queue.Peek());
		// queue.Enqueue(6);
		// queue.Dequeue();
		// foreach(int i in queue)
		// {
		// 	Console.WriteLine(i);
		// }
		
		
		//Stack
		Stack<int> myStack = new();
		myStack.Push(2);
		myStack.Push(3);
		myStack.Push(4);
		myStack.Pop();
		foreach(int i in myStack)
		{
			Console.WriteLine(i);
		}
		Console.WriteLine(myStack.Peek());
		
	}
}