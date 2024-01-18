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
		
		// awalnya pakai yang ini
		// DoTaskOne(); 
		// DoTaskTwo(); 
		
		Thread thread1 = new Thread(DoTaskOne); //Constructornya itu delegate
		Thread thread2 = new Thread(DoTaskTwo);
		thread1.Start();
		thread2.Start();
		//Walaupun main threadnya selesai tetapi background threadnya itu masih berjalan
		
		//Biar thread 1 dan thread 2 jalan terlebih dahulu sebelum main threadnya
		thread1.Join();
		thread2.Join();
		
		Console.WriteLine("Finished Program");
		stopwatch.Stop();
	}
	public static void DoTaskOne()
	{
		Console.WriteLine(Thread.CurrentThread.ManagedThreadId);//print Thread Id untuk DoTaskOne
		for (int i=0;i<1000;i++)
		{
			Console.Write("+");
		}
	}
	public static void DoTaskTwo()
	{
		Console.WriteLine(Thread.CurrentThread.ManagedThreadId);//print Thread Id untuk DoTaskTwo
		for (int i=0;i<1000;i++)
		{
			Console.Write("-");
		}
	}
}