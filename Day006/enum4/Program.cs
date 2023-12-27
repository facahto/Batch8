class Program
{
	static void Main()
	{
		GameController gameStart = new GameController();
		gameStart()
	}
}
class GameController
{
	private GameStatus _gamestatus;
	private IPlayer _player;
	public GameController()
	{
		//Awal Game
		_gamestatus = GameStatus.NotInitialized;
	}
	public bool AddPlayer(IPlayer player)
	{
		if(_player is null)
		{
			return false;
		}
		if(_gamestatus is GameStatus.NotInitialized)
		{
			return false;
		}
		_player = player;
		_gamestatus = GameStatus.Ready;
		return true;
	}
}
public enum GameStatus
{
	NotInitialized,
	Ready,
	Playing,
}
public interface IPlayer
{
	public int ID {get;}
	public string Name {get;}
}