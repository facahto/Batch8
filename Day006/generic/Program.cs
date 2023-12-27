﻿class Program
{
	static void Main()
	{
		MyCollection<int> myIntCollection = new(3);
		myIntCollection.AddObject(4);
		myIntCollection.AddObject(3);
		myIntCollection.AddObject(2);
		//Console.WriteLine(myIntCollection.AddObject(4)); out false
		Console.WriteLine(myIntCollection.GetData(4)); //out: 0 as default
		Console.WriteLine(myIntCollection.GetData(0));
	}
}
class MyCollection<T>
{
	public T[] myCollection;
	public int count;
	public MyCollection(int size)
	{
		myCollection = new T[size];
		count = -1;
	}
	public bool AddObject(T obj)
	{
		if (count == myCollection.Length-1)
		{
			return false;
		}
		count++;
		myCollection[count] = obj;
		return true;
	}
	public T GetData(int index)
	{
		if (index>myCollection.Length-1)
		{
			return default;
		}
		return myCollection[index];
	}
}