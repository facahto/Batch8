class Program
{
	static void Main()
	{
		Car car = new Car(3)
		Action<int> print = car.Print;
		print();
	}
}
class Car
{
	public int i;
	public Car(int i)
	{
		this.i= i;
	}
	public void Print()
	{
		Console.WriteLine(i);
	}
}
