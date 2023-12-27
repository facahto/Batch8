class Program
{
	static void Main()
	{
		var day = DaysOfWeek.Monday;
		DayCheck(day);
	}
	static void DayCheck(DaysOfWeek day)
	{
		if(day == DaysOfWeek.Monday)
		{
			Console.WriteLine("Today is Monday");
		}
	}
}
public enum DaysOfWeek
{
	Monday,
	Tuesday,
	Wednesday
}
/*
class Program
{
	static void Main()
	{
		var day = "Monday";
		DayCheck(day);
	}
	static void DayCheck(string day)
	{
		if(day == "Monday")
		{
			Console.WriteLine("Today is Monday");
		}
	}
}
*/