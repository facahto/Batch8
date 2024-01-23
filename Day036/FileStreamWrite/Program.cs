using System.Security.AccessControl;
using System.IO;
using System.Text;
class Program {
	static void Main() {
		string path = "bootcamp.txt";

		//Create
		using (FileStream fs = new FileStream(path, FileMode.Create)) {

			byte[] data = Encoding.UTF8.GetBytes("Hello, FileStream!"); 
			fs.Write(data, 0, data.Length); //data, offset, count
		}

		//Write
		using (FileStream fs = new FileStream(path, FileMode.Open)) {
			byte[] buffer = new byte[fs.Length]; //masih kosongan
			fs.Read(buffer, 0, buffer.Length); //buffer, offset, count
			string content = Encoding.UTF8.GetString(buffer); //diubah jadi string lagi 
			Console.WriteLine(content);
		}
	}
}