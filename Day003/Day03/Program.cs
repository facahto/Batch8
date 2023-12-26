using Day03;

class Program
{
	static void Main()
	{
		Calculator calculator = new();
		int resultOfSum = calculator.Add(2,3,4,5,6);
		int resultOfMul = calculator.Mul(2,3,4,5);
		Console.WriteLine(resultOfSum); 
		Console.WriteLine(resultOfMul); 
		
		/* note for params:
				1. jika ada lebih dari dua argumen berupa integer dan string, maka 
				   params harus ditempatkan sebagai argumen terakhir
				2. jika ada dua lebih string di dalam parameter yang berisikan param,
				   maka string ke dua tidak akan terbaca
		*/
		int result = calculator.Add("a","b",3,4,4); //poin 2
		Console.WriteLine(result);
	}
}
