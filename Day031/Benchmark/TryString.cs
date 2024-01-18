using System.Text;
using BenchmarkDotNet.Attributes;
[MemoryDiagnoser]
public class StringBenchmarker
{
	[Params(10,25,50)]
	public int N;
	[Benchmark]
	public void StringTest()
	{
		string a = "";
		for (int i=0;i<N;i++)
		{
			a+=i.ToString();
		}
	}
	[Benchmark]
	public void StringBuilderTest()
	{
		StringBuilder sb = new();
		for (int i=0;i<N;i++)
		{
			sb.Append(i);
		}
	}	
}