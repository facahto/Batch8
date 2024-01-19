using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Mail;
using System.Threading.Tasks;

class Program
{
	// static async Task Main()
	// {
	// 	Task result1 = Task.Run(()=> Console.WriteLine("task1"));
	// 	Task result2 = Task.Run(()=> Console.WriteLine("task2"));
	// 	await result1;
	// }
	
	static async Task Main()
	{
		Console.WriteLine("starting...");
		await DoWork();
		Console.WriteLine("finishing...");
	}
	static async Task DoWork()
	{
		Console.WriteLine("Starting the asynchronous work...");
		await Task.Delay(2000);
		Console.WriteLine("Asynchronous work completed.");
	}
}