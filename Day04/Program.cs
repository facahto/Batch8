
using Day04;
class Program
{
	static void Main()
	{
		Cat cat = new Cat(2,"Carlos");
		Console.WriteLine(cat.age);
		
		Animal animal = new Animal(6,"Harry");
		Console.WriteLine(animal.age);
	}
}