class Program
{
	static void Main()
	{
		int a = 3;
		Console.WriteLine("Initial Value "+a);
		Multiplier(in a);
		Console.WriteLine("Final Value "+a);
	}
	static void Multiplier(in int input)
	{
		int result = input + 3;
	}
}