/*
---OVERIDING
*/
class Program
{
	static void Main()
	{
		Animal animal = new Animal();
		Dog dog = new Dog();
		dog.MakeSound(); // Bark
		Animal animal2 = dog;
		animal2.MakeSound(); // Bark
	}
}

class Animal
{
	public virtual void MakeSound()
	{
		Console.WriteLine("make sound");
	}
}
class Dog : Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Bark");
	}
}  

/* 
-- METHOD HIDING

class Program
{
	static void Main()
	{
		Animal animal = new Animal();
		Dog dog = new Dog();
		dog.MakeSound(); //Bark
		Animal animal2 = dog;
		animal2.MakeSound(); //Make Sound
	}
}

class Animal
{
	public void MakeSound()
	{
		Console.WriteLine("make sound");
	}
}
class Dog : Animal
{
	public new void MakeSound()
	{
		Console.WriteLine("Bark");
	}
}*/
