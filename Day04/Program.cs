
using Day04;
class Program
{
	static void Main()
	{
		
		Cat cat = new Cat();
		cat.Eat("Ikan");
		cat.meow();
		
		Dog dog = new Dog();
		dog.Eat("Tulang");
		dog.bark();
		
		Bird bird = new Bird();
		bird.Eat("Biji");
		bird.chirp();
		
	}
}