class Program
{
	static void Main()
	{
		//buat instance dari publisher sama subcriber
		GameController game = new GameController();
		SMS sms = new SMS();
		
		game.mySubscriber = sms.SendSMS;
		game.UpdateGameStatus();
	}
}
//DELEGATE
public delegate void MyDelegate(string message);

//PUBLISHER
class GameController
{
	public MyDelegate mySubscriber;
	public GameController(){}
	public void UpdateGameStatus()
	{
		string status = "game Running";
		mySubscriber.Invoke(status);
	}
}

//SUBSCRIBER
class SMS
{
	public void SendSMS(string message)
	{
		Console.WriteLine("SMS " + message);
	}
}