class Program
{
	public delegate int MyDelegate(int x, int b);
	static void Main()
	{
		MyDelegate myDel = Add;
		myDel += Mul;
		int result = myDel(3,4);
		int result2 = myDel.Invoke(3,4);
		result.Dump();
		result.Dump();
	}
	static int Add(int a,int b)
	{
		return a+b;
	}
	static int Mul(int a,int b)
	{
		return a*b;
	}
}
public static class StringExtention
{
	public static void Dump(this object x)
	{
		Console.WriteLine(x);
	}
}