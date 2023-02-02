// * Detailed results *
DuplBench.DelGenBench: DefaultJob
Runtime = .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX; GC = Concurrent Workstation
Mean = 17.702 us, StdErr = 0.131 us (0.74%), N = 95, StdDev = 1.274 us
Min = 15.761 us, Q1 = 16.723 us, Median = 17.553 us, Q3 = 18.569 us, Max = 21.231 us
IQR = 1.846 us, LowerFence = 13.955 us, UpperFence = 21.338 us
ConfidenceInterval = [17.258 us; 18.146 us] (CI 99.9%), Margin = 0.444 us (2.51% of Mean)
Skewness = 0.53, Kurtosis = 2.62, MValue = 2
-------------------- Histogram --------------------
[15.759 us ; 16.568 us) | @@@@@@@@@@@@@@@@@@@@
[16.568 us ; 17.300 us) | @@@@@@@@@@@@@@@@@@@@@@
[17.300 us ; 18.209 us) | @@@@@@@@@@@@@@@@@@@@@@@@@@
[18.209 us ; 19.238 us) | @@@@@@@@@@@@@@
[19.238 us ; 20.159 us) | @@@@@@@@
[20.159 us ; 20.892 us) | @@@@
[20.892 us ; 21.597 us) | @
---------------------------------------------------

DuplBench.DelCompBench: DefaultJob
Runtime = .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX; GC = Concurrent Workstation
Mean = 20.111 us, StdErr = 0.098 us (0.49%), N = 17, StdDev = 0.405 us
Min = 19.219 us, Q1 = 19.910 us, Median = 20.222 us, Q3 = 20.442 us, Max = 20.629 us
IQR = 0.532 us, LowerFence = 19.112 us, UpperFence = 21.240 us
ConfidenceInterval = [19.717 us; 20.505 us] (CI 99.9%), Margin = 0.394 us (1.96% of Mean)
Skewness = -0.54, Kurtosis = 2.23, MValue = 2
-------------------- Histogram --------------------
[19.150 us ; 19.620 us) | @@
[19.620 us ; 20.034 us) | @@@@@@
[20.034 us ; 20.633 us) | @@@@@@@@@
---------------------------------------------------

DuplBench.DelNonCompBench: DefaultJob
Runtime = .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX; GC = Concurrent Workstation
Mean = 58.369 us, StdErr = 0.317 us (0.54%), N = 29, StdDev = 1.709 us
Min = 55.311 us, Q1 = 57.077 us, Median = 58.157 us, Q3 = 59.300 us, Max = 62.286 us
IQR = 2.223 us, LowerFence = 53.742 us, UpperFence = 62.635 us
ConfidenceInterval = [57.204 us; 59.535 us] (CI 99.9%), Margin = 1.166 us (2.00% of Mean)
Skewness = 0.58, Kurtosis = 2.71, MValue = 2
-------------------- Histogram --------------------
[54.581 us ; 55.763 us) | @
[55.763 us ; 56.902 us) | @@@@
[56.902 us ; 58.362 us) | @@@@@@@@@@@@
[58.362 us ; 60.034 us) | @@@@@@@@
[60.034 us ; 62.378 us) | @@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19044.2364/21H2/November2021Update)
AMD FX(tm)-8350, 1 CPU, 8 logical and 4 physical cores
Frequency=14318180 Hz, Resolution=69.8413 ns, Timer=HPET
.NET SDK=7.0.102
  [Host]     : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX [AttachedDebugger]
  DefaultJob : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX


|          Method |     Mean |    Error |   StdDev |
|---------------- |---------:|---------:|---------:|
|     DelGenBench | 17.70 us | 0.444 us | 1.274 us |
|    DelCompBench | 20.11 us | 0.394 us | 0.405 us |
| DelNonCompBench | 58.37 us | 1.166 us | 1.709 us |