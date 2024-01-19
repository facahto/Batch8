using System;
using System.Threading.Tasks;

static class Program
{
	static async Task Main(string[] args)
	{
		Console.WriteLine("Main Method Started");

		var task1 = Task.Run(async() => 
		{
			Console.WriteLine("Task1 started");
			await Task.Delay(1000);
			Console.WriteLine("Task1 waiting Task2");
		});
		
		var task2 = Task.Run(async() => 
		{
			Console.WriteLine("Task2 started");
			await Task.Delay(1000);
			Console.WriteLine("Task2 waiting Task1");
		});
		
		await Task.WhenAll(task1,task2);

		Console.WriteLine("All tasks completed");
		Console.ReadKey();
	}
}