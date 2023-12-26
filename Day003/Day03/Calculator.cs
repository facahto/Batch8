namespace Day03;

public class Calculator
{
	// params int[] : menyataan array
	public int Add(params int[] numbers)
	{
		int result = 0;
		foreach(int number in numbers)
		{
			result = result+number;
		}
		return result;
	}
	public int Mul(params int[] numbers)
	{
		int result = 1;
		foreach(int number in numbers)
		{
			result = result*number;
		}
		return result;
	}
	public int Add(string a,string b,params int[] numbers)
	{
		Console.WriteLine(a);
		int result = 0;
		foreach(int number in numbers) //looping elemen array
		{
			result = result+number;
		}
		return result;
	}
}