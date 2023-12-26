class Car
{
	public readonly int year;
	public const string brand = "Honda";
	
	public Car(int year)
	{
		this.year = year;
	}
}

class Program
{
	static void Main()
	{
		Car car = new Car(2008);
		Console.WriteLine(car.year);
	}
}

