namespace Day04;

public class Cat : Animal
{
	public Cat(int age, string name) : base(age,name)
	{
		this.age = age;
		this.name = name;
	}
	public void meow()
	{
		Console.WriteLine("cat is meowing");
	}
}