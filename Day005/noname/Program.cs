class Car
{
	static int count;
	public int price = 5;
	public void GetPrice()
	{
		Console.WriteLine(price);
	}
}
class Program
{
	static void Main()
	{
		Car.GetPrice();
	}
}