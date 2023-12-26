class EducatorChecker
{
	public void CheckCollege(Student student)
	{
		Console.WriteLine(student.College());
	}
	public void CheckHighSchool(Student student)
	{
		Console.WriteLine(student.HighSchool());
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
		EducatorChecker education = new EducatorChecker();
		education.CheckCollege(new JakartaStudent());
		education.CheckHighSchool(new JogjakartaStudent());
	}
}