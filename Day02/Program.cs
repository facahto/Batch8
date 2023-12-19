using Day02;

class Program
{
	static void Main()
	{
		Cat cimol = new Cat(2,"domestic","white");
		Console.WriteLine(cimol.age);
		Console.WriteLine(cimol.species);
		Console.WriteLine(cimol.color);
		Cat bolu = new Cat(1,"domestic","grey");
		Console.WriteLine(bolu.age);
		Console.WriteLine(bolu.species);
		Console.WriteLine(bolu.color);
	}
}