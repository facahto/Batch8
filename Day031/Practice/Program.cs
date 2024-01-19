using System.Diagnostics;
using BenchmarkDotNet.Running;

class Program
{
	static async Task Main()
	{
		Stopwatch Stopwatch = new Stopwatch();
		Stopwatch.Start();
		await TryAsync.MyMethod();
		Stopwatch.Stop();
		
	}
}