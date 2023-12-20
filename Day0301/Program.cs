class Program
{
	static void Main()
	{
		Calculator calc = new Calculator();
		Console.WriteLine(calc.x); // inacessible 
		Console.WriteLine(calc.GetY); // inacessible 
		Console.WriteLine(calc.GetX);
	}
}

class Calculator
{
	int x; // private
	int y; // private
	
	int GetY()
	{
		return y;
	}
	
	int GetX()
	{
		Console.WriteLine(x);
	}
}