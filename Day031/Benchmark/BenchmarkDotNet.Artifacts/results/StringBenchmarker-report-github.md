```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3007/22H2/2022Update/SunValley2)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
| Method            | N  | Mean        | Error      | StdDev    | Median      | Gen0   | Allocated |
|------------------ |--- |------------:|-----------:|----------:|------------:|-------:|----------:|
| **StringTest**        | **10** |   **223.29 ns** |   **8.654 ns** |  **24.69 ns** |   **218.83 ns** | **0.0801** |     **336 B** |
| StringBuilderTest | 10 |    92.38 ns |   4.298 ns |  12.33 ns |    87.38 ns | 0.0248 |     104 B |
| **StringTest**        | **25** |   **826.99 ns** |  **37.034 ns** | **106.85 ns** |   **804.15 ns** | **0.4740** |    **1984 B** |
| StringBuilderTest | 25 |   389.12 ns |  15.202 ns |  44.34 ns |   379.15 ns | 0.0973 |     408 B |
| **StringTest**        | **50** | **2,256.15 ns** | **130.080 ns** | **375.31 ns** | **2,142.02 ns** | **1.6098** |    **6736 B** |
| StringBuilderTest | 50 |   716.94 ns |  46.263 ns | 130.49 ns |   666.18 ns | 0.1526 |     640 B |
