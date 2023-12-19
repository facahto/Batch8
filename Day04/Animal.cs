namespace Day04;

public class Animal
{
	public string name;
	public int age;
	public Animal(string name, int age)
	{
		this.age = age;
		this.name = name;
	}
	public void Eat(string food)
	{
		Console.WriteLine($"Eat {food}");
	}
}