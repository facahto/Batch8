class Program
{
	static void Main()
	{
		//instance untuk publisher dan subscriber
		Subscriber sub1 = new Subscriber();
		Subscriber sub2 = new Subscriber();
		Subscriber sub3 = new Subscriber();
		
		Youtuber youtuber = new Youtuber();
		
		youtuber.AddSubscriber(sub1.GetNotification).Dump();
		youtuber.AddSubscriber(sub1.GetNotification).Dump();
		youtuber.AddSubscriber(sub3.GetNotification).Dump();
		youtuber.UploadVideo();
	}
}
public delegate void MySubscriber(string message);
//Publisher
class Youtuber
{
	private event MySubscriber mySubscriber; //EVENT
	public bool AddSubscriber(MySubscriber sub)
	{
		if(mySubscriber is null)
		{
			mySubscriber = sub;
			return true;
		}
		//Untuk cek apakah sub sudah ada dilistnya
		if(mySubscriber.GetInvocationList().Contains(sub))
		{
			return false;
		}
		mySubscriber += sub;
		return true;
	}
	public void UploadVideo()
	{
		Console.WriteLine("Uploading...");
		Console.WriteLine("Finished");
		// Console.WriteLine("Here is my new video");
		SendNotification("Here is new video.");
		// kenapa ga disini? mySubscriber.Invoke(message);
		// kalo di setiap metode disisipkan invoke juga berpengaruh pada performa
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

public static class StringExtention
{
	public static void Dump(this object x)
	{
		Console.WriteLine(x);
	}
	
}