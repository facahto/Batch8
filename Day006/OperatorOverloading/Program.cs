using System.Numerics;


// operator hanya bisa digunakan untuk tipe data
// bisa untuk class tapi dengan adanya kondisi
class Calculator<T> where T:IAdditionOperators<T,T,T>
{
	public T Addition(T a, T b)
	{
		return a+b;
	}
}
class Program
{
	static void Main()
	{
		Calculator<int> calculator = new();
		int result = calculator.Addition(3,4);
		result.GetType().Dump();
		result.Dump();
}
}
public static class StringExtention
{
	public static void Dump(this object x)
	{
		Console.WriteLine(x);
	}
}