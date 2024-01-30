using Microsoft.EntityFrameworkCore;
using MySqlTutorial;
using SQLitePCL;

class Program
{
	static void Main()
	{
		
		using(Northwind db = new())
		{
			Console.WriteLine(db.Database.CanConnect());
			
			// List<Category> categories = db.Categories
			// .Include(d => d.Products)
			// .ToList();
			// foreach(var c in categories)
			// {
			// 	Console.WriteLine($"{c.CategoryId} : {c.CategoryName}");
			// 	foreach(var p in c.Products)
			// 	{
			// 		Console.WriteLine($"	{p.ProductId} : {p.ProductName}");
			// 	}
			// }
			
			//var products = db.Products.Where(p => p.Cost>20);
			//var products = db.Products.OrderByDescending(p => p.ProductName);
			// var products = db.Products.OrderBy(p=>p.ProductName);
			// foreach(var p in products)
			// {
			// 	Console.WriteLine($"{p.ProductName} : {p.Cost}");
			// }
			// var priceaverage = db.Products.Average(p=>p.Cost);
			// Console.WriteLine($"Price average: {priceaverage}");
			// var countproduct = db.Products.Count();
			// Console.WriteLine($"Count product: {countproduct}");
			// var countproduct = db.Products.Count();
			// Console.WriteLine($"Count product: {countproduct}");
			// var maxprice = db.Products.Max(p => p.Cost);
			// Console.WriteLine($"Max price: {maxprice}");
			// var select_ = db.Products.Select(p=>p.ProductName);
			// foreach(var t in select_)
			// {
			// 	Console.WriteLine(t);
			// }
			var contains = db.Products.Include(p=>p.Supplier);
			foreach(var i in contains)
			{
				Console.WriteLine(i);
			}
			
		}
	}
}
class Northwind : DbContext
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Products> Products { get; set; }
	public DbSet<Supplier> Suppliers { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
	{
		optionBuilder.UseSqlite("FileName=./Northwind.db");
	}
}