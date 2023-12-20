
using Day04;
class Program
{
	static void Main()
	{
		Animal animal = new Animal(6,"Harry");
		Console.WriteLine(animal.age);
		
		Cat cat = new Cat(2,"Carlos","White");
		Console.WriteLine(cat.age);
		Console.WriteLine(cat.name);
		
		Bird bird = new Bird(5,"Larry","pigeon");
		Console.WriteLine(bird.age);
		Console.WriteLine(bird.name);
		
		Dog dog = new Dog(1,"Gloria","27km");
		Console.WriteLine(dog.age);
		Console.WriteLine(dog.name);
	}
}