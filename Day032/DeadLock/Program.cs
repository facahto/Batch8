class Program
{
	static async void Main()
	{
		Console.WriteLine("Main Method Started");
		Task task1 = null;
		Task task2 = null;
		task1 = Task.Run(async() => {
			Console.WriteLine("Task 1 started");
			await Task.Delay(10);
			
			Console.WriteLine("Task 1 started");
			await task2;
			
			Console.WriteLine("Task 1 completed");
		});
		task2 = Task.Run(async() => {
			Console.WriteLine("Task 1 started");
			await Task.Delay(10);
			
			Console.WriteLine("Task 1 started");
			await task1;
			
			Console.WriteLine("Task 1 completed");
		});
		await Task.WhenAll(task1,task2);
		
		Console.WriteLine("Main Method completed");
		Console.ReadKey();
	}
}