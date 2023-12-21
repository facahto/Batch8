
// OUT

class Program
{
	static void Main()
	{
		int a = 3000;
		Console.WriteLine("Initial value " + a); // out: 3000
		Multiplier(out a);
		Console.WriteLine("Final Value "+a); // out 200
		
		string myString = "341";
		bool staturOfParsing = int.TryParse(myString, out int result);
		Console.WriteLine(result);
		Console.WriteLine(staturOfParsing);
	}
	static void Multiplier(out int input)
	{
		input = 200;
		
	}
}

/*class Program
{
	static void Main()
	{
		int a = 3;
		Console.WriteLine("Initial value " + a); // out: 3
		Multiplier(out a);
		Console.WriteLine("Final Value "+a); // out 5
		
	}
	static void Multiplier(out int input)
	{
		input = 5;
	}
}*/


/*class Program 
{
	static void Main() 
	{
		int a = 3;
		Console.WriteLine("Initial value " + a);
		Multiplier(in a);
		Console.WriteLine("Final value " + a);
	}
	static void Multiplier(in int input) 
	{
		int result = input + 3;
	}
}
*/

