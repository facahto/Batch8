abstract class Animal //Base Clasee
{
	protected int age; //public juga bisa
	protected string name;
	public Animal(int age, string name) 
	{
		this.age = age;
		this.name = name;
	}
	
	protected abstract void AnimalSound(); //abstract means class_child must have implementation (method)
	public virtual void Run() 
	{
		Console.WriteLine("Animal Running");
	}
}

class Dog : Animal
{
	public Dog(int age, string name) : base(age,name)
	{
		
	}
	protected override void AnimalSound()
	{
		Console.WriteLine("Bark");
	}
	public override void Run()
	{
		Console.WriteLine("Dog run");
	}
	
}

class Program
{
	static void Main()
	{
		/*with abstract, we cant instantiate abstract class, 
		we must fill it with child that implement it*/
		//Animal animal = new Animal(4,"dog"); --> ERROR
		Animal animal = new Dog(4,"dog"); 
		//animal.AnimalSound() --> ERROR
		//C.W(animal.age); --> ERROR
		animal.Run();
	}
}