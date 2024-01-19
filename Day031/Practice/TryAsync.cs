using System.Text;
using BenchmarkDotNet.Attributes;
[MemoryDiagnoser]
public class TryAsync
{
	//[Benchmark]
	public static Task MyMethod()
	{
		return Task.Delay(2000);
	}
	//[Benchmark]
	public async Task MyMethod2()
	{
		await Task.Delay(2000);
	}
}