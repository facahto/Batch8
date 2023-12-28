//SUBSCRIBER
class SMS
{
	public void SendSMS(string message)
	{
		Console.WriteLine("SMS " + message);
	}
}
class Email
{
	public void SendEmail(string message)
	{
		Console.WriteLine("email " + message);
	}
}
class DataBase
{
	public void SendDatabase(string message)
	{
		Console.WriteLine("database " + message);
	}
}
class API
{
	public void SendAPI(string message)
	{
		Console.WriteLine("API " + message);
	}
}
//PUBLISHER
class GameController
{
	public MyDelegate mySubscriber;
	public GameController()
	{
		
	}
	public void UpdateGameStatus()
	{
		
		string status = "game Running";
		mySubscriber.Invoke(status);
	}
}
public delegate void MyDelegate(string message);
class Program
{
	static void Main()
	{
		//instance untuk publisher sama subscriber
		GameController game = new GameController();
		SMS sms = new SMS();
		Email email = new Email();
		DataBase database = new DataBase();
		API api = new API();
		game.mySubscriber = sms.SendSMS;
		game.mySubscriber += email.SendEmail;
		game.mySubscriber += database.SendDatabase;
		game.mySubscriber += api.SendAPI;
		game.UpdateGameStatus();
	}
}