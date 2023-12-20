using System.Drawing;

namespace Day04;

public class Bird : Animal
{
	public string species;
	public Bird(int age, string name, string species) : base(age,name)
	{
		this.species = species;
	}
	
	public void chirp()
	{
		Console.WriteLine("bird is chirping");
	}

}