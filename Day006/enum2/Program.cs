class Program
{
	static void Main()
	{
		Player player = new Player(Condition.InProgress);
		Player player2 = new Player(Condition.InProgress);
		Console.WriteLine(player.condition == player2.condition);
	}
}

class Player
{
	public Condition condition;
	public Player(Condition condition)
	{
		this.condition = condition;
	}
}
public enum Condition
{
	InProgress,
	Win,
	Lose
}
