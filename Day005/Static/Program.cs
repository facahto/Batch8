//static: bukan milik instance, satu untuk semua (disharing)
class Program
{
	static void Main()
	{
		Human human = new Human("a");
		Console.WriteLine(human.GetName());
		Console.WriteLine(Human.Counter());
		
		Human human2 = new Human("b");
		Console.WriteLine(human2.GetName());
		Console.WriteLine(Human.Counter());
		
		Human human3 = new Human("b");
		Console.WriteLine(human3.GetName());
		Console.WriteLine(Human.Counter());
	}
}
class Human
{
	public static int count = 0;
	public string name;
	public Human(string name)
	{
		count++;
		this.name = name;
	}
	public static int Counter()
	{
		return count;
	}
	public string GetName()
	{
		return name;
	}
}
/*
class Car
{
	public static int count = 0;
	public int price =5 ;

	public static GetPrice()
	{
		Console.WriteLine(price);
	}
}
class Program
{
	static void Main()
	{
		Console.WriteLine(Car.GetPrice());
	}
}
class Program
{
	static void Main()
	{
		Console.WriteLine(Calculator.Add(3,4));
	}
}
class Calculator
{
	public static int Add(int a, int b)
	{
		return a+b;
	}
}*/