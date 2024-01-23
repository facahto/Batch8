using System.Text.Json;

public class Person
{
	public string Name {get; set;}
	public int Age{get; set;}
}
class Program
{
	static void Main()
	{
		List<Person> people = new List<Person>
		{
			new Person{Name = "Charlie", Age = 12},
			new Person{Name = "Alice", Age = 30},
		};
		//ubah ke JSON
		string jsonstring = JsonSerializer.Serialize(people);
		using (StreamWriter writer = new StreamWriter("person.json"))
		{
			writer.Write(jsonstring);
		}
		string jsonFromFile;
		using(StreamReader reader = new StreamReader("person.json"))
		{
			jsonFromFile = reader.ReadToEnd();
		}
		List<Person> deserializedPeople = JsonSerializer.Deserialize<List<Person>>(jsonFromFile);
		foreach (var person in deserializedPeople)
		{
			Console.WriteLine($"Deserialize Person: {person.Name}, {person.Age}");
		}
	}
}