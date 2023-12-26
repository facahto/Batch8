public interface IPrinter
{
	void Fax();
	void Print();
	void Scan();
}
public class Printer30Juta : IPrinter
{
	public void Fax()
	{
		Console.WriteLine("Printer30Juta Fax");
	}
	public void Print()
	{
		Console.WriteLine("Printer30Juta Print");
	}
	public void Scan()
	{
		Console.WriteLine("Printer30Juta Scan");
	}
	public void Other()
	{
		Console.WriteLine("check");
	}
}
public class Printer1Juta : IPrinter
{
	public void Fax()
	{
		Console.WriteLine("Printer1Juta Fax");
	}
	public void Scan()
	{
		Console.WriteLine("Printer1Juta Scan");
	}
	public void Print()
	{
		Console.WriteLine("Printer1Juta Print");
	}
}
class Program
{
	static void Main()
	{
		PrinterSedang(new Printer1Juta());
		PrinterMahal(new Printer30Juta());
	}
	static void PrinterMahal(IPrinter printer)
	{
		printer.Print();
	}
	static void PrinterSedang(IPrinter printer)
	{
		printer.Scan();
	}
}