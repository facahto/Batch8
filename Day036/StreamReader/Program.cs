using System;
using System.IO;
namespace FileHandlinDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string filePath = "MyFile.txt";

           
            StreamReader streamReader = new StreamReader(filePath); //cukup pake pathnya aja

            Console.WriteLine("Content of the File");

            streamReader.BaseStream.Seek(0, SeekOrigin.Begin); //(0,SeekOrigin.Begin) mulai bacanya dari mana
            
            string strData = streamReader.ReadLine();

           
            while (strData != null)
            {
                Console.WriteLine(strData);
                strData = streamReader.ReadLine();
            }
            Console.ReadLine();

            streamReader.Close();
            Console.ReadKey();
        }
    }
}