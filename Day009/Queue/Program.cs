using System.Collections;

class Program
{
	static void Main()
	{
		Queue
		Queue<int> queue = new();
		queue.Enqueue(3);
		queue.Enqueue(4);
		queue.Enqueue(5);
		Console.WriteLine(queue.Peek());
		queue.Enqueue(6);
		queue.Dequeue();
		foreach(int i in queue)
		{
			Console.WriteLine(i);
		}
	}
}