```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3007/22H2/2022Update/SunValley2)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
| Method    | Mean    | Error    | StdDev   | Allocated |
|---------- |--------:|---------:|---------:|----------:|
| MyMethod  | 1.006 s | 0.0067 s | 0.0062 s |   1.42 KB |
| MyMethod2 | 1.002 s | 0.0080 s | 0.0075 s |    1.2 KB |
