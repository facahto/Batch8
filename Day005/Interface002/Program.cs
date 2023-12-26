public interface IPrint
{
	void Print(); //abstrak
}
public interface IScan
{
	void Scan(); //abstrak
}
public interface IFax
{
	void Fax(); //abstrak
}
public interface IPrinterMahal : IPrint, IScan, IFax{}

// CLASS CHILD
public class Printer100ribu : IPrint
{
	public void Print()
	{
		Console.WriteLine("Printer100ribu Print");
	}
}
public class Printer1juta : IPrinterMahal
{
	public void Print()
	{
		Console.WriteLine("Printer1juta Print");
	}
	public void Fax()
	{
		Console.WriteLine("Printer1juta Fax");
	}
	public void Scan()
	{
		Console.WriteLine("Printer1juta Scan");
	}
}

class Program
{
	static void Main()
	{
		Printer(new Printer1juta());
		Printer2(new Printer100ribu());
	}
	static void Printer(IPrinterMahal printer)
	{
		printer.Scan();
	}
	static void Printer2(IPrint printer)
	{
		printer.Print();
	}
}