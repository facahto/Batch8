using System.Collections;

class Program
{
	static void Main()
	{
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