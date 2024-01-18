```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3007/22H2/2022Update/SunValley2)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
| Method            | N  | Mean        | Error     | StdDev    | Median      | Gen0   | Allocated |
|------------------ |--- |------------:|----------:|----------:|------------:|-------:|----------:|
| **StringTest**        | **10** |   **211.34 ns** |  **8.905 ns** | **25.692 ns** |   **202.53 ns** | **0.0801** |     **336 B** |
| StringBuilderTest | 10 |    83.84 ns |  1.704 ns |  3.201 ns |    83.52 ns | 0.0248 |     104 B |
| **StringTest**        | **25** |   **675.02 ns** | **13.539 ns** | **25.760 ns** |   **671.94 ns** | **0.4740** |    **1984 B** |
| StringBuilderTest | 25 |   296.40 ns |  5.344 ns |  4.173 ns |   298.11 ns | 0.0973 |     408 B |
| **StringTest**        | **50** | **1,583.47 ns** | **21.362 ns** | **20.980 ns** | **1,581.28 ns** | **1.6098** |    **6736 B** |
| StringBuilderTest | 50 |   562.21 ns | 10.809 ns |  9.582 ns |   565.07 ns | 0.1526 |     640 B |
