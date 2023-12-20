

class Parent
{
	string _name = "parent";
	protected int age = 2; // Protected: hanya bisa diakses oleh anaknya saja
	public void ParentMethodA()
	{
		Console.WriteLine("Its parent");
	}
	
	protected void ParentMethodB()
	{
		Console.WriteLine("Its parent B");
	}
}

class Child : Parent // Anaknya
{
	public void ChildMethodA()
	{
		Console.WriteLine(age);
	}
}

class Program
{
	static void Main()
	{
		Child child = new();
		child.ChildMethodA();
		
		/*Parent parent = new Parent();
		parent.age();
		Non-invocable member 'Parent.age*/
	}
}