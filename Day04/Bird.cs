namespace Day04;

public class Bird : Animal
{
	public Bird(int age, string name) : base(age,name)
	{
		this.age = age;
		this.name = name;
	}
	
	public void chirp()
	{
		Console.WriteLine("bird is chirping");
	}

}