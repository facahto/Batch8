class Program
{
	static void Main()
	{
		Console.WriteLine("start");
		Human human = new Human();
		Console.WriteLine(human.NameCounter());
		Console.WriteLine("finish");
		
	}
}
class Human
{
	private string name;
	public int NameCounter()
	{
		int count;
		try
		{
			count = name.Length;
		}
		catch(Exception e)
		{
			count = 0;
		}
		return count;
	}
}