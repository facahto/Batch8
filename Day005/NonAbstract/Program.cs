class Human
{
	public string Name {get;} //readonly ga ada setnya, ga bisa diubah, hanya bisa dibaca
	private Student _student; // abstract class
	public Human(string name, Student student)
	{
		Name = name;
		_student = student;
	}
	public void CheckCollege()
	{
		Console.WriteLine(_student.College());
	}
	public void CheckHighSchool()
	{
		Console.WriteLine(_student.HighSchool());
	}
}
abstract class Student
{
	public abstract string HighSchool();
	public abstract string College();
}
class JakartaStudent : Student
{
	public override string HighSchool()
	{
		return "SMA 1 Jakarta";
	}
	public override string College()
	{
		return "Binus";
	}
	
}
class JogjakartaStudent : Student
{
	public override string HighSchool()
	{
		return "DB2";
	}
	public override string College()
	{
		return "UGM";
	}
}
class Program
{
	static void Main()
	{
		Human human = new Human("Vidya",new JakartaStudent());
		human.CheckHighSchool();
		human.CheckCollege();
	}
}