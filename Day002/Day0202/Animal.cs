namespace Day04;

public class Animal
{
	public string name;
	public int age;
	public Animal(int age, string name)
	{
		this.age = age;
		this.name = name;
	}
	public void Eat(string food)
	{
		Console.WriteLine($"Eat {food}");
	}
}