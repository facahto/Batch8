class Program
{
	static void Main()
	{
	// 	string a="3a";
	// 	int result = int.Parse(a); // System.FormatException:
	
	//Program tetap jalan
	Console.WriteLine("Start");
	string a = "3a";
	try
	{
		int result = int.Parse(a);
	}
	// catch(FormatException e)
	// {
	// 	Console.WriteLine(e.Message);
	// }
	//Yang Exception lebih generic berlaku untuk semua error
	catch(Exception e)
	{
		Console.WriteLine(e.Message);
	}
	Console.WriteLine("Finish");
	}
}