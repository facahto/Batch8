using System;
using System.Diagnostics;
using System.Threading;
class Program
{
	static void Main()
	{
		Thread thread = new Thread(DoWork);
		Thread secondThread = new Thread(DoWork);
		
		thread.Start();
		secondThread.Start();
		
		thread.Join();
		secondThread.Join();
		
		Console.WriteLine("Main thread exiting");
		
	}
	static void DoWork()
	{
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} started.");
		Thread.Sleep(2000);
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} finished.");
	}
	
}