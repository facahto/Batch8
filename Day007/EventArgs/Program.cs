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
	// ------ EventHandler
	public event EventHandler<MyEventArgs> mySubscriber; //EVENT
	public Publisher(string name){
		Name = name;
	}
	public void SendNotification()
	{
		// ------ Invoke
		mySubscriber?.Invoke(this, new MyEventArgs(){data = "data"});
	}
	/*overide from class object
	class object: class paling pertama*/
	public override string ToString()
	{
		return Name;
	}
}
class Youtuber
{
	public string Name {get;}
	// ------ EventHandler
	public event EventHandler<MyEventArgs> mySubscriber; 
	public Youtuber(string name)
	{
		Name = name;
	}
	public void UploadVideo()
	{
		Console.WriteLine("Uploading...");
		Console.WriteLine("Finished");
		SendNotification("Here is my new video");
	}
	public void SendNotification(string message)
	{
		// ------ Invoke
		mySubscriber?.Invoke(this, new MyEventArgs(){data = "data"});
	}
	public override string ToString()
	{
		return Name;
	}
}
//Subscriber
class Subscriber
{
	// ------ EventHandler
	public void GetNotification(object sender, MyEventArgs e)
	{
		Console.WriteLine("Subscriber get notified: " + sender + e.data);
		
	}
}
class MyEventArgs : EventArgs
{
	public string data;
}
