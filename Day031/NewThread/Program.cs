using System.Diagnostics;

class Program
{
	static void Main()
	{
		Console.WriteLine("Starting Program");
		
		var stopwatch = new Stopwatch();
		stopwatch.Start();
		
		Thread thread1 = new Thread(DoTaskOne);
		Thread thread2 = new Thread(DoTaskTwo);
		Thread thread3 = new Thread(DoTaskOne);
		Thread thread4 = new Thread(DoTaskTwo);
		
		thread1.Start();
		thread2.Start();
		thread3.Start();
		thread4.Start();
		
		thread1.Join();
		thread2.Join();
		thread3.Join();
		thread4.Join();
		
		stopwatch.Stop();
		Console.WriteLine("Finished Program");
	}
	public static void DoTaskOne()
	{
		for (int i=0;i<100;i++)
		{
			Console.Write("+");
		}
	}
	public static void DoTaskTwo()
	{
		for (int i=0;i<100;i++)
		{
			Console.Write("-");
		}
	}
}