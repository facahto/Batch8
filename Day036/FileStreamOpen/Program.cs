using System;
using System.IO;
using System.Text;

namespace FileHandlinDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			string FilePath = "MyFile.txt";

			using (FileStream fileStream = new FileStream(FilePath, FileMode.Append))
			{
				//ubah ke byte dulu
				byte[] bytedata = Encoding.Default.GetBytes("C# Is an Object Oriented Programming Language");

				//array (bytedata): The buffer containing data to write to the stream.
				//offset (0): The zero-based byte offset in the array from which to begin copying bytes to the stream.
				//count (bytedata.Length): The maximum number of bytes to write.
				Console.WriteLine(bytedata.Length);
				fileStream.Write(bytedata, 0, bytedata.Length); //write
				fileStream.Close();
			}
			Console.WriteLine("Successfully saved file with data : C# Is an Object Oriented Programming Language");
			//akan ada file baru 
			Console.ReadKey();
		}
	}
}