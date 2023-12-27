class Program
{
	static void Main()
	{
		string myString = "asd";
		myString.Dump();
		
		int result = 1.Tambah(2,3);
		result.Dump();
	}
}
public static class StringExtention
{
	public static void Dump(this object x)
	{
		Console.WriteLine(x);
	}
	public static int Tambah(this int x, int y, int z)
	{
		return x + y + z;
	}
}