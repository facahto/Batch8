class Program
{
	static void Main()
	{
		//instance untuk publisher dan subscriber
		Subscriber subs1 = new Subscriber();
		Subscriber subs2 = new Subscriber();
		Subscriber subs3 = new Subscriber();
		
		Youtuber youtuber = new Youtuber("Yusuf");
		youtuber.mySubscriber += subs3.GetNotification;
		youtuber.UploadVideo();
		
		Youtuber youtuber2 = new Youtuber("Yanto");
		
		youtuber2.UploadVideo();
		
		Publisher publisher = new Publisher("Jarot");
		publisher.mySubscriber +=subs1.GetNotification;
		publisher.SendNotification();
	}
}

//Publisher
class Publisher
{
	public string Name;
	public event EventHandler mySubscriber; 
	public Publisher(string name){
		Name = name;
	}
	public void SendNotification()
	{
		mySubscriber.Invoke(this,EventArgs.Empty);
	}
	public override string ToString()
	{
		//Func
		return Name;
	}
}
class Youtuber
{
	public string Name {get;}
	public event EventHandler mySubscriber; 
	public Youtuber(string name)
	{
		Name = name;
	}
	public void UploadVideo()
	{
		//action
		Console.WriteLine("Uploading...");
		Console.WriteLine("Finished");
		SendNotification("Here is my new video");
	}
	public void SendNotification(string message)
	{
		mySubscriber?.Invoke(this,EventArgs.Empty);
	}
	public override string ToString()
	{
		//Func
		return Name;
	}
}
//Subscriber
class Subscriber
{
	public void GetNotification(object sender, EventArgs e)
	{
		Console.WriteLine("Subscriber get notified: "+sender);
	}
}