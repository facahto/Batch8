using System;
using System.Diagnostics;
using System.Threading;
class Program
{
	static void Main()
	{
		//Environment 
		Console.WriteLine(Environment.ProcessorCount);
		
		//Print Thread Id Main
		Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
		
		Console.WriteLine("Starting Program");
		var stopwatch = new Stopwatch();
		stopwatch.Start();
		
		
		Thread thread1 = new Thread(DoTaskOne); 
		Thread thread2 = new Thread(DoTaskTwo);
		thread1.Start();
		thread2.Start();
		
		thread1.Join();
		thread2.Join();
		
		Console.WriteLine("Finished Program");
		stopwatch.Stop();
	}
	public static void DoWork()
	{
		Console.WriteLine(Thread.CurrentThread.ManagedThreadId);//print Thread Id untuk DoTaskOne
		for (int i=0;i<1000;i++)
		{
			Console.Write("+");
		}
	}
	
}