namespace Day04;

public class Cat : Animal
{
	public string color;
	public Cat(int age, string name, string color) : base(age,name)
	{
		this.color = color;
	}
	
	public void meow()
	{
		Console.WriteLine("cat is meowing");
	}
}