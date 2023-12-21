class Program
{
	static void Main()
	{
		Car cara = new Car(3);
		Car carb = cara;
		carb.price = carb.price + 2;
		Console.WriteLine($"price a: {cara.price}");
		Console.WriteLine($"price b: {carb.price}");
		/* Karena class itu reference type jadi yang dicopy
		 itu hanya addressnya saja bukan valuenya */
		
	}
}

class Car
{
	public int price;
	
	public Car(int x)
	{
		price = x;
	}
}