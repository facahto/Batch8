namespace Day04;

public class Dog : Animal
{
	public Dog(int age, string name) : base(age,name)
	{
		this.age = age;
		this.name = name;
	}
	public void bark()
	{
		Console.WriteLine("dog is barking");
	}
}