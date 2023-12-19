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
	
	//overload: di saat isi dari parameter memiliki beragam argumen atau argumen yang tidak lengkap
	public void Eat(string food) 
	{
		Console.WriteLine($"Eat {food}");
	}
	public void Eat(string food,int count) 
	{
		for (int i = 0; i < count; i++)
		{
			Console.WriteLine($"Eat {food} for {i} times");
		}
	}
	public void Eat(int count) 
	{
		Console.WriteLine($"Eat for {count} times");
	}
}
