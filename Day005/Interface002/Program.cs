public interface IPrint
{
	void Print(); 
}
public interface IScan
{
	void Scan(); 
}
public interface IFax
{
	void Fax(); 
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
		printer.Print();
		printer.Scan();
	}
	static void Printer2(IPrint printer)
	{
		printer.Print();
	}
}