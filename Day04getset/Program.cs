/*class Program
{
	static void Main()
	{

	}
}
class Human
{
	private string _name;
	public int Brand { get; private set; } //common practice 
	public int Piece { get;  } //readonly
	public string Name //custom properties
	{
		get
		{
			return _name;
		}
		set
		{
			_name = _name + value;
		}
	}
	public string GetName()
	{
		return _name;
	}
	public void ChangeNameToDefault()
	{
		Name = String.Empty;
	}
	// public void SetName(string name)
	// {
	// 	_name = name;
	// }
}


// car.x => variable
// car.X => property
// car.X() => method
*/


class Person
{
	private string name;
	public string Name
	{
		get{return name;} // kita get name dari private string
		set{name = value;} // set value Name = name
	}
}

class Program
{
	static void Main()
	{
		Person person = new();
		person.Name = "K";
		Console.WriteLine(person.Name);
	}
}



