namespace Day04;

public class Dog : Animal
{
	public string speed;
	public Dog(int age, string name, string speed) : base(age,name)
	{
		this.speed = speed;
	}
	public void bark()
	{
		Console.WriteLine("dog is barking");
	}
}