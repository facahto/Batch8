
class Program
{
	static void Main()
	{
		#if BAMBANG
		#region Bambang
		{
			Console.WriteLine("BAMBANG");
		}
		#endregion
		#elif YANTO
		#region Yanto
		{
			Console.WriteLine("YANTO");
		}
		#endregion
		#else
		#region Selamet
		{
			Console.WriteLine("SELAMET");
		}
		#endregion
		#endif
	}
}