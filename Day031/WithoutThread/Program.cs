using System;
using System.Diagnostics;
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
		
		DoTaskOne(); //Method ini yang pertama keluar
		DoTaskTwo(); //Method ini yang keluar kedua
		//thread Id untuk kedua method masih sama, jadi perlu dibikin instancenya
		
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