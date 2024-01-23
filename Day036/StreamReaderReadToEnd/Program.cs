using System;
using System.IO;
namespace FileHandlinDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "MyFile.txt";

            StreamReader streamReader = new StreamReader(filePath);

            Console.WriteLine("Content of the File");
            
            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine(reader.ReadToEnd()); //works best when you need to read all the input from the current position to the end of the stream.
            }
            
            Console.ReadKey();
        }
    }
}