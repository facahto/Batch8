class Program
{
	static void Main()
	{
		//instance untuk publisher dan subscriber
		Subscriber subs1 = new Subscriber();
		Subscriber subs2 = new Subscriber();
		Subscriber subs3 = new Subscriber();
		
		Youtuber youtuber = new Youtuber();
		
		youtuber.mySubscriber += subs1.GetNotification;
		youtuber.mySubscriber += subs1.GetNotification;
		youtuber.UploadVideo();
	}
}
public delegate void MySubscriber(string message);
//Publisher
class Youtuber
{
	public event MySubscriber mySubscriber; //EVENT
	public void UploadVideo()
	{
		Console.WriteLine("Uploading...");
		Console.WriteLine("Finished");
		Console.WriteLine("Here is my new video");
	}
	public void SendNotification(string message)
	{
		mySubscriber.Invoke(message);
	}
}
//Subscriber
class Subscriber
{
	public void GetNotification(string message)
	{
		Console.WriteLine("Subscriber get notified"+message);
	}
}