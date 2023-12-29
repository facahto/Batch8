using System.Collections;
class Program
{
	static void Main()
	{
		int[] myInt = {1,2,3};
		IEnumerator enumerator = myInt.GetEnumerator();
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);
		Console.WriteLine(enumerator.Reset())
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);
	}
}