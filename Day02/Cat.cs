namespace Day02;

public class Cat
{
	public int age;
	public string species;
	public string color;
	
	public Cat(int age, string species, string color)
	{
		this.age = age;
		this.species = species;
		this.color = color;
	}
	
	public void Meow()
	{
		Console.WriteLine("Meow");
	}
}