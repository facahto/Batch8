using System.Numerics;
class Program
{
	static void Main()
	{
		Car cara = new Car(5000,10,"a");
		Car carb = new Car(3000,11,"b");
		Car carc = new Car(2000,12,"c");
		Car card = cara+carb+carc;
		card.price.Dump();
	}
}
// 
public class Car : IAdditionOperators<Car,Car,Car>
{
	public int year;
	public int price;
	public string name;
	public Car(int price, int year, string name)
	{
		this.price = price;
		this.year = year;
		this.name = name;
	}
	public static Car operator +(Car left, Car right)
	{
		Car resultCar = new Car(left.price+right.price,0,"");
		return resultCar;
	}
	
}
public static class StringExtention
{
	public static void Dump(this object x)
	{
		Console.WriteLine(x);
	}
}