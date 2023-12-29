class Program
{
	static void Main()
	{
		var myFunc = (int a,int b) =>{return a+b;};
		int result = myFunc(3,4);
		Console.WriteLine(result);
		
		var myFunc2 = (int a) =>{return a>0;};
		bool result2 = myFunc2(3);
		Console.WriteLine(result2);
		
		var myAction = (string a) => {Console.WriteLine(a);};
		myAction("hello");
		
		var myAction2 = () =>{Console.WriteLine("Hello");};
		myAction2();
		
		var myAction3 = (string a) => (a);
		Console.WriteLine(myAction3("Hello"));
		
		var myFunc3 = (int a,int b) =>
		{
			a+=10;
			b*=2;
			return a+b;
		};
		int result4 = myFunc3(4,5);
		Console.WriteLine(result4);
	}
}