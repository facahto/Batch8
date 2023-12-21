using System;
using System.Text;

// STRING, IMMUTABLE, STRING BUILDER

/*
string a = "hello ";
string b = a;
b = b+"world";
Console.WriteLine(a); // out: Hello
Console.WriteLine(b); // out: Hello World
*-----------------------------------/


/*
string a = "hello ";
a += "world ";
a += "world ";
Console.WriteLine(a); // out: hello world world
*-----------------------------------/

/*
class Program
{
	static void Main()
	{
		StringBuilder sb =  new StringBuilder("Hello");
		sb.Append("Hello");
		sb.Append("Hello");
		Console.WriteLine(sb);
	}
}---------------------------------------*/

/*
class Program
{
	static void Main()
	{
		Car car = new();
		car.brand[0]=9; // Tidak error karena yang readonly hanya arraynya saja
		car.year = 2000;
		//car.price=20; ERROR karena readonly
		Console.WriteLine(car.brand[0]); // 9
		Console.WriteLine(car.year);//
		Console.WriteLine(car.price);//
	}
}
class Car
{
	public readonly int[] brand = {1,2,3};
	public int year;
	public readonly int price;
}----------------------------------------*/

/*
class Program
{
	static void Main()
	{
		Car car = new();
		car.brand[0]=9; // Tidak error karena yang readonly hanya arraynya saja
		// car.brand = new int[3]; error: A readonly field cannot be assigned to
		Console.WriteLine(car.brand[1]);
	}
}
class Car
{
	public readonly int[] brand = new int[3];
	
}-------------------------------------------*/


class Program
{
	static void Main()
	{
		
	}
}
class Adder
{
	public void Adder(int a)
	{
		a+=3
	}
	
}