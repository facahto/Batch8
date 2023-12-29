class Program
{
	static void Main()
	{
		Human human = new Human();
		Console.WriteLine(human.NameCounter());
	}
}
class Human
{
	private string name;
	public Human()
	{
		
	}
	public int NameCounter()
	{
		if (name is not null)
		{
			return name.Length;
		}
		return 0;
		//Atau pake ini:
		//return name is not null? name.Length : 0;
	}
}