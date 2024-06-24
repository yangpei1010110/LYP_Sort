Simple Zero Alloc Sort For Unity Game

BenchmarkDotNet:
ValueTypeSort ResultData:
```ValueType
| Method          | testCount | Mean          | Error       | Ratio | Allocated |
|---------------- |---------- |--------------:|------------:|------:|----------:|
| ArraySortByte   | 1000      |    106.273 us |   4.3935 us |  1.00 |     400 B |
| RadixSortByte   | 1000      |      2.213 us |   0.0786 us |  0.02 |     400 B |
| ArraySortSByte  | 1000      |    101.108 us |   1.8808 us |  0.93 |     400 B |
| RadixSortSByte  | 1000      |      2.531 us |   0.0665 us |  0.02 |     400 B |
| ArraySortShort  | 1000      |    106.783 us |   2.3992 us |  1.01 |     400 B |
| RadixSortShort  | 1000      |      4.436 us |   0.0921 us |  0.04 |     400 B |
| ArraySortUShort | 1000      |     95.699 us |   2.3410 us |  0.90 |     400 B |
| RadixSortUShort | 1000      |      3.911 us |   0.0829 us |  0.04 |     400 B |
| ArraySortUInt   | 1000      |     26.116 us |   0.5192 us |  0.24 |     400 B |
| RadixSortUInt   | 1000      |      7.508 us |   0.1486 us |  0.06 |     400 B |
| ArraySortInt    | 1000      |     28.526 us |   1.0744 us |  0.27 |     400 B |
| RadixSortInt    | 1000      |     10.006 us |   0.2014 us |  0.08 |     400 B |
| ArraySortULong  | 1000      |     27.753 us |   1.0494 us |  0.26 |     400 B |
| RadixSortULong  | 1000      |     14.150 us |   0.2866 us |  0.13 |     400 B |
| ArraySortLong   | 1000      |    107.004 us |   2.1346 us |  1.01 |     400 B |
| RadixSortLong   | 1000      |     15.653 us |   0.2574 us |  0.14 |     400 B |
|                 |           |               |             |       |           |
| ArraySortByte   | 10000     |    759.273 us |  15.1749 us |  1.00 |     400 B |
| RadixSortByte   | 10000     |     12.073 us |   0.2406 us |  0.02 |     400 B |
| ArraySortSByte  | 10000     |    770.462 us |  13.4694 us |  1.01 |     400 B |
| RadixSortSByte  | 10000     |     13.962 us |   0.2754 us |  0.02 |     400 B |
| ArraySortShort  | 10000     |  1,059.927 us |  20.5723 us |  1.33 |     400 B |
| RadixSortShort  | 10000     |     29.531 us |   0.3605 us |  0.04 |     400 B |
| ArraySortUShort | 10000     |  1,021.168 us |  20.3785 us |  1.33 |     400 B |
| RadixSortUShort | 10000     |     27.554 us |   0.4137 us |  0.03 |     400 B |
| ArraySortUInt   | 10000     |    380.354 us |   6.0780 us |  0.47 |     400 B |
| RadixSortUInt   | 10000     |     51.574 us |   1.1661 us |  0.07 |     400 B |
| ArraySortInt    | 10000     |    374.207 us |   4.5390 us |  0.47 |     400 B |
| RadixSortInt    | 10000     |     63.633 us |   1.2616 us |  0.08 |     400 B |
| ArraySortULong  | 10000     |    375.385 us |   7.0487 us |  0.47 |     400 B |
| RadixSortULong  | 10000     |    135.399 us |   4.5511 us |  0.18 |     400 B |
| ArraySortLong   | 10000     |  1,022.400 us |   7.8391 us |  1.27 |     400 B |
| RadixSortLong   | 10000     |    147.398 us |   3.8102 us |  0.19 |     400 B |
|                 |           |               |             |       |           |
| ArraySortByte   | 100000    |  6,637.567 us | 122.0989 us |  1.00 |      64 B |
| RadixSortByte   | 100000    |    100.129 us |   1.9660 us |  0.01 |     400 B |
| ArraySortSByte  | 100000    |  7,090.793 us |  83.0446 us |  1.07 |     400 B |
| RadixSortSByte  | 100000    |    128.886 us |   2.5062 us |  0.02 |     400 B |
| ArraySortShort  | 100000    | 10,963.073 us | 145.8315 us |  1.65 |     400 B |
| RadixSortShort  | 100000    |    276.670 us |   4.6347 us |  0.04 |     400 B |
| ArraySortUShort | 100000    |  4,550.114 us |  48.5645 us |  0.69 |     400 B |
| RadixSortUShort | 100000    |    232.685 us |   2.9918 us |  0.04 |     400 B |
| ArraySortUInt   | 100000    |  4,729.669 us |  60.1135 us |  0.71 |     112 B |
| RadixSortUInt   | 100000    |    497.614 us |   5.3455 us |  0.07 |     400 B |
| ArraySortInt    | 100000    |  4,545.429 us |  67.2364 us |  0.68 |     400 B |
| RadixSortInt    | 100000    |    542.656 us |   7.1331 us |  0.08 |     400 B |
| ArraySortULong  | 100000    |  4,564.707 us |  60.1143 us |  0.69 |     400 B |
| RadixSortULong  | 100000    |  1,163.543 us |  22.0631 us |  0.18 |     400 B |
| ArraySortLong   | 100000    |  4,539.894 us |  43.8756 us |  0.69 |     400 B |
| RadixSortLong   | 100000    |  1,251.835 us |  23.4001 us |  0.19 |     400 B |
|                 |           |               |             |       |           |
| ArraySortByte   | 1000000   | 27,605.436 us | 225.2417 us |  1.00 |     400 B |
| RadixSortByte   | 1000000   |  1,027.014 us |  20.3735 us |  0.04 |     400 B |
| ArraySortSByte  | 1000000   | 28,291.607 us | 137.9002 us |  1.03 |     400 B |
| RadixSortSByte  | 1000000   |  1,333.771 us |  25.9408 us |  0.05 |     400 B |
| ArraySortShort  | 1000000   | 49,827.160 us | 260.5677 us |  1.81 |     400 B |
| RadixSortShort  | 1000000   |  2,821.178 us |  52.9325 us |  0.10 |     400 B |
| ArraySortUShort | 1000000   | 49,621.200 us | 278.5316 us |  1.80 |     400 B |
| RadixSortUShort | 1000000   |  2,710.776 us |  71.0849 us |  0.09 |     400 B |
| ArraySortUInt   | 1000000   | 54,868.040 us | 240.0825 us |  1.99 |     400 B |
| RadixSortUInt   | 1000000   |  6,638.300 us | 257.5394 us |  0.23 |     400 B |
| ArraySortInt    | 1000000   | 56,276.220 us | 396.6534 us |  2.04 |     400 B |
| RadixSortInt    | 1000000   |  6,631.973 us | 303.9811 us |  0.23 |     400 B |
| ArraySortULong  | 1000000   | 56,272.857 us | 254.8532 us |  2.04 |     400 B |
| RadixSortULong  | 1000000   | 16,429.203 us | 692.6925 us |  0.60 |     400 B |
| ArraySortLong   | 1000000   | 55,390.800 us | 266.1001 us |  2.01 |     400 B |
| RadixSortLong   | 1000000   | 17,445.317 us | 657.8060 us |  0.66 |     400 B |
```
ValueTypeSort TestCode:
```csharp
using BenchmarkDotNet.Attributes;
using LYP_Sort.LSortLib.LRadixSort;

namespace LYP_Sort_Test;

[MemoryDiagnoser]
public class BenchmarkSortWithValueType
{
    [Params(1_000, 10_000, 100_000, 1_000_000)]
    public int testCount;

    public byte[]   sourceByte   = Array.Empty<byte>();
    public byte[]   targetByte   = Array.Empty<byte>();
    public sbyte[]  sourceSByte  = Array.Empty<sbyte>();
    public sbyte[]  targetSByte  = Array.Empty<sbyte>();
    public short[]  sourceShort  = Array.Empty<short>();
    public short[]  targetShort  = Array.Empty<short>();
    public ushort[] sourceUShort = Array.Empty<ushort>();
    public ushort[] targetUShort = Array.Empty<ushort>();
    public int[]    sourceInt    = Array.Empty<int>();
    public int[]    targetInt    = Array.Empty<int>();
    public uint[]   sourceUInt   = Array.Empty<uint>();
    public uint[]   targetUInt   = Array.Empty<uint>();
    public long[]   sourceLong   = Array.Empty<long>();
    public long[]   targetLong   = Array.Empty<long>();
    public ulong[]  sourceULong  = Array.Empty<ulong>();
    public ulong[]  targetULong  = Array.Empty<ulong>();

    public LRadixSort<byte>?   LRadixSortByte;
    public LRadixSort<sbyte>?  LRadixSortSByte;
    public LRadixSort<short>?  LRadixSortShort;
    public LRadixSort<ushort>? LRadixSortUShort;
    public LRadixSort<int>?    LRadixSortInt;
    public LRadixSort<uint>?   LRadixSortUInt;
    public LRadixSort<long>?   LRadixSortLong;
    public LRadixSort<ulong>?  LRadixSortULong;

    [GlobalSetup]
    public void Setup()
    {
        LRadixSortByte = LRadixSortFactory.CreateNonGeneric<byte>(1_000_000);
        LRadixSortSByte = LRadixSortFactory.CreateNonGeneric<sbyte>(1_000_000);
        LRadixSortShort = LRadixSortFactory.CreateNonGeneric<short>(1_000_000);
        LRadixSortUShort = LRadixSortFactory.CreateNonGeneric<ushort>(1_000_000);
        LRadixSortInt = LRadixSortFactory.CreateNonGeneric<int>(1_000_000);
        LRadixSortUInt = LRadixSortFactory.CreateNonGeneric<uint>(1_000_000);
        LRadixSortLong = LRadixSortFactory.CreateNonGeneric<long>(1_000_000);
        LRadixSortULong = LRadixSortFactory.CreateNonGeneric<ulong>(1_000_000);
        Random r = new();

        sourceByte = new byte[testCount];
        targetByte = new byte[testCount];
        sourceUShort = new ushort[testCount];
        targetUShort = new ushort[testCount];
        sourceUInt = new uint[testCount];
        targetUInt = new uint[testCount];
        sourceULong = new ulong[testCount];
        targetULong = new ulong[testCount];

        sourceSByte = new sbyte[testCount];
        targetSByte = new sbyte[testCount];
        sourceShort = new short[testCount];
        targetShort = new short[testCount];
        sourceInt = new int[testCount];
        targetInt = new int[testCount];
        sourceLong = new long[testCount];
        targetLong = new long[testCount];

        for (int i = 0; i < sourceUShort.Length; i++)
        {
            sourceSByte[i] = (sbyte)BitConverter.GetBytes(r.NextInt64())[0];
            sourceUShort[i] = BitConverter.ToUInt16(BitConverter.GetBytes(r.NextInt64()));
            sourceUInt[i] = BitConverter.ToUInt32(BitConverter.GetBytes(r.NextInt64()));
            sourceULong[i] = BitConverter.ToUInt64(BitConverter.GetBytes(r.NextInt64()));

            sourceByte[i] = BitConverter.GetBytes(r.NextInt64())[0];
            sourceShort[i] = BitConverter.ToInt16(BitConverter.GetBytes(r.NextInt64()));
            sourceInt[i] = BitConverter.ToInt32(BitConverter.GetBytes(r.NextInt64()));
            sourceLong[i] = BitConverter.ToInt64(BitConverter.GetBytes(r.NextInt64()));
        }
    }

    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(sourceByte, targetByte, testCount);
        Array.Copy(sourceUShort, targetUShort, testCount);
        Array.Copy(sourceUInt, targetUInt, testCount);
        Array.Copy(sourceULong, targetULong, testCount);

        Array.Copy(sourceSByte, targetSByte, testCount);
        Array.Copy(sourceShort, targetShort, testCount);
        Array.Copy(sourceInt, targetInt, testCount);
        Array.Copy(sourceLong, targetLong, testCount);

        GC.Collect();
    }

    [IterationCleanup]
    public void IterationCleanup()
    {
        Array.Clear(targetByte);
        Array.Clear(targetUShort);
        Array.Clear(targetUInt);
        Array.Clear(targetULong);
        Array.Clear(targetSByte);
        Array.Clear(targetShort);
        Array.Clear(targetInt);
        Array.Clear(targetLong);
        GC.Collect();
    }

    [Benchmark(Baseline = true)]
    public void ArraySortByte()
    {
        Array.Sort(targetByte);
    }

    [Benchmark]
    public void RadixSortByte()
    {
        LRadixSortByte!.Sort(targetByte);
    }

    [Benchmark]
    public void ArraySortSByte()
    {
        Array.Sort(targetSByte);
    }

    [Benchmark]
    public void RadixSortSByte()
    {
        LRadixSortSByte!.Sort(targetSByte);
    }

    [Benchmark]
    public void ArraySortShort()
    {
        Array.Sort(targetShort);
    }

    [Benchmark]
    public void RadixSortShort()
    {
        LRadixSortShort!.Sort(targetShort);
    }

    [Benchmark]
    public void ArraySortUShort()
    {
        Array.Sort(targetUShort);
    }

    [Benchmark]
    public void RadixSortUShort()
    {
        LRadixSortUShort!.Sort(targetUShort);
    }

    [Benchmark]
    public void ArraySortUInt()
    {
        Array.Sort(targetUInt);
    }

    [Benchmark]
    public void RadixSortUInt()
    {
        LRadixSortUInt!.Sort(targetUInt);
    }

    [Benchmark]
    public void ArraySortInt()
    {
        Array.Sort(targetInt);
    }

    [Benchmark]
    public void RadixSortInt()
    {
        LRadixSortInt!.Sort(targetInt);
    }

    [Benchmark]
    public void ArraySortULong()
    {
        Array.Sort(targetULong);
    }

    [Benchmark]
    public void RadixSortULong()
    {
        LRadixSortULong!.Sort(targetULong);
    }

    [Benchmark]
    public void ArraySortLong()
    {
        Array.Sort(targetLong);
    }

    [Benchmark]
    public void RadixSortLong()
    {
        LRadixSortLong!.Sort(targetLong);
    }
}
```
ClassTypeSort ResultData
```ClassType
| Method          | testCount | Mean          | Error       | Ratio | Allocated |
|---------------- |---------- |--------------:|------------:|------:|----------:|
| ArraySortByte   | 1000      |    131.540 us |  20.6035 us |  1.00 |     400 B |
| RadixSortByte   | 1000      |      9.735 us |   0.2244 us |  0.09 |     400 B |
| ArraySortSByte  | 1000      |    157.327 us |  13.9465 us |  1.53 |     400 B |
| RadixSortSByte  | 1000      |      9.109 us |   0.1940 us |  0.09 |     400 B |
| ArraySortShort  | 1000      |    138.812 us |  21.9635 us |  1.09 |     400 B |
| RadixSortShort  | 1000      |     14.383 us |   0.2986 us |  0.11 |     400 B |
| ArraySortUShort | 1000      |    158.196 us |  18.1418 us |  1.61 |     400 B |
| RadixSortUShort | 1000      |     16.064 us |   0.6362 us |  0.16 |     400 B |
| ArraySortUInt   | 1000      |    169.207 us |  19.9874 us |  1.72 |     400 B |
| RadixSortUInt   | 1000      |     28.299 us |   0.7447 us |  0.27 |     400 B |
| ArraySortInt    | 1000      |    162.577 us |  24.3820 us |  1.32 |     400 B |
| RadixSortInt    | 1000      |     28.141 us |   0.8725 us |  0.28 |     736 B |
| ArraySortULong  | 1000      |    166.770 us |  20.0751 us |  1.51 |     400 B |
| RadixSortULong  | 1000      |     49.894 us |   1.2923 us |  0.49 |     400 B |
| ArraySortLong   | 1000      |    175.468 us |  21.9061 us |  1.78 |     400 B |
| RadixSortLong   | 1000      |     53.378 us |   1.4340 us |  0.53 |     400 B |
|                 |           |               |             |       |           |
| ArraySortByte   | 10000     |  1,153.692 us | 218.0185 us |  1.00 |     400 B |
| RadixSortByte   | 10000     |     77.206 us |   1.8617 us |  0.09 |     400 B |
| ArraySortSByte  | 10000     |    710.035 us | 122.4008 us |  0.75 |      64 B |
| RadixSortSByte  | 10000     |     73.127 us |   2.1641 us |  0.08 |     736 B |
| ArraySortShort  | 10000     |    756.469 us |  26.5226 us |  0.78 |     400 B |
| RadixSortShort  | 10000     |    125.070 us |   2.6264 us |  0.14 |     400 B |
| ArraySortUShort | 10000     |    740.483 us |   8.4620 us |  0.60 |     400 B |
| RadixSortUShort | 10000     |    126.213 us |   2.5135 us |  0.12 |     400 B |
| ArraySortUInt   | 10000     |    832.759 us |  25.9890 us |  0.85 |     400 B |
| RadixSortUInt   | 10000     |    297.858 us |  10.5648 us |  0.34 |     400 B |
| ArraySortInt    | 10000     |    843.641 us |  10.5759 us |  0.59 |     400 B |
| RadixSortInt    | 10000     |    236.408 us |   4.4257 us |  0.17 |     400 B |
| ArraySortULong  | 10000     |  1,377.381 us | 263.8605 us |  1.25 |     400 B |
| RadixSortULong  | 10000     |    463.971 us |   9.2461 us |  0.34 |     112 B |
| ArraySortLong   | 10000     |    845.090 us |  25.9175 us |  0.87 |     400 B |
| RadixSortLong   | 10000     |    486.020 us |   9.6560 us |  0.44 |     400 B |
|                 |           |               |             |       |           |
| ArraySortByte   | 100000    |  7,933.538 us | 157.1494 us |  1.00 |     400 B |
| RadixSortByte   | 100000    |  1,426.461 us | 118.2472 us |  0.17 |     400 B |
| ArraySortSByte  | 100000    |  8,508.345 us | 167.9675 us |  1.07 |     400 B |
| RadixSortSByte  | 100000    |  1,658.835 us | 143.4817 us |  0.21 |      64 B |
| ArraySortShort  | 100000    | 11,133.854 us | 216.1598 us |  1.42 |     400 B |
| RadixSortShort  | 100000    |  3,164.255 us | 195.2751 us |  0.40 |     400 B |
| ArraySortUShort | 100000    | 10,517.872 us | 207.5001 us |  1.33 |     112 B |
| RadixSortUShort | 100000    |  3,095.139 us | 168.2012 us |  0.39 |      64 B |
| ArraySortUInt   | 100000    | 12,204.662 us | 244.0688 us |  1.53 |     400 B |
| RadixSortUInt   | 100000    |  4,701.356 us | 184.5410 us |  0.59 |     400 B |
| ArraySortInt    | 100000    | 12,093.167 us | 237.8599 us |  1.52 |      64 B |
| RadixSortInt    | 100000    |  4,910.705 us | 197.3270 us |  0.63 |     112 B |
| ArraySortULong  | 100000    | 12,168.754 us | 240.7449 us |  1.53 |     400 B |
| RadixSortULong  | 100000    | 10,370.201 us | 351.6483 us |  1.35 |     400 B |
| ArraySortLong   | 100000    | 12,033.173 us | 240.4887 us |  1.51 |     400 B |
| RadixSortLong   | 100000    |  9,131.737 us | 268.7225 us |  1.15 |      64 B |
```

ClassTypeSort TestCode:
```csharp
using BenchmarkDotNet.Attributes;
using LYP_Sort.LSortLib.LRadixSort;

namespace LYP_Sort_Test;

[MemoryDiagnoser]
public class BenchmarkSortWithBytePoint
{
    public class BytePoint<TKey>
    {
        public TKey key;
        public byte value;

        public BytePoint(TKey key)
        {
            this.key = key;
            value = 0;
        }
    }

    [Params(1_000, 10_000, 100_000)]
    public int testCount;

    public BytePoint<byte>[]   sourceByte   = Array.Empty<BytePoint<byte>>();
    public BytePoint<byte>[]   targetByte   = Array.Empty<BytePoint<byte>>();
    public BytePoint<sbyte>[]  sourceSByte  = Array.Empty<BytePoint<sbyte>>();
    public BytePoint<sbyte>[]  targetSByte  = Array.Empty<BytePoint<sbyte>>();
    public BytePoint<short>[]  sourceShort  = Array.Empty<BytePoint<short>>();
    public BytePoint<short>[]  targetShort  = Array.Empty<BytePoint<short>>();
    public BytePoint<ushort>[] sourceUShort = Array.Empty<BytePoint<ushort>>();
    public BytePoint<ushort>[] targetUShort = Array.Empty<BytePoint<ushort>>();
    public BytePoint<int>[]    sourceInt    = Array.Empty<BytePoint<int>>();
    public BytePoint<int>[]    targetInt    = Array.Empty<BytePoint<int>>();
    public BytePoint<uint>[]   sourceUInt   = Array.Empty<BytePoint<uint>>();
    public BytePoint<uint>[]   targetUInt   = Array.Empty<BytePoint<uint>>();
    public BytePoint<long>[]   sourceLong   = Array.Empty<BytePoint<long>>();
    public BytePoint<long>[]   targetLong   = Array.Empty<BytePoint<long>>();
    public BytePoint<ulong>[]  sourceULong  = Array.Empty<BytePoint<ulong>>();
    public BytePoint<ulong>[]  targetULong  = Array.Empty<BytePoint<ulong>>();

    public LRadixSort<BytePoint<byte>>?   LRadixSortByte;
    public LRadixSort<BytePoint<sbyte>>?  LRadixSortSByte;
    public LRadixSort<BytePoint<short>>?  LRadixSortShort;
    public LRadixSort<BytePoint<ushort>>? LRadixSortUShort;
    public LRadixSort<BytePoint<int>>?    LRadixSortInt;
    public LRadixSort<BytePoint<uint>>?   LRadixSortUInt;
    public LRadixSort<BytePoint<long>>?   LRadixSortLong;
    public LRadixSort<BytePoint<ulong>>?  LRadixSortULong;

    [GlobalSetup]
    public void Setup()
    {
        LRadixSortByte = LRadixSortFactory.CreateGeneric<BytePoint<byte>, byte>(p => p.key, 1_000_000);
        LRadixSortSByte = LRadixSortFactory.CreateGeneric<BytePoint<sbyte>, sbyte>(p => p.key, 1_000_000)!;
        LRadixSortShort = LRadixSortFactory.CreateGeneric<BytePoint<short>, short>(p => p.key, 1_000_000)!;
        LRadixSortUShort = LRadixSortFactory.CreateGeneric<BytePoint<ushort>, ushort>(p => p.key, 1_000_000)!;
        LRadixSortInt = LRadixSortFactory.CreateGeneric<BytePoint<int>, int>(p => p.key, 1_000_000)!;
        LRadixSortUInt = LRadixSortFactory.CreateGeneric<BytePoint<uint>, uint>(p => p.key, 1_000_000)!;
        LRadixSortLong = LRadixSortFactory.CreateGeneric<BytePoint<long>, long>(p => p.key, 1_000_000)!;
        LRadixSortULong = LRadixSortFactory.CreateGeneric<BytePoint<ulong>, ulong>(p => p.key, 1_000_000)!;
        Random r = new();

        sourceByte = new BytePoint<byte>[testCount];
        targetByte = new BytePoint<byte>[testCount];
        sourceUShort = new BytePoint<ushort>[testCount];
        targetUShort = new BytePoint<ushort>[testCount];
        sourceUInt = new BytePoint<uint>[testCount];
        targetUInt = new BytePoint<uint>[testCount];
        sourceULong = new BytePoint<ulong>[testCount];
        targetULong = new BytePoint<ulong>[testCount];
        sourceSByte = new BytePoint<sbyte>[testCount];
        targetSByte = new BytePoint<sbyte>[testCount];
        sourceShort = new BytePoint<short>[testCount];
        targetShort = new BytePoint<short>[testCount];
        sourceInt = new BytePoint<int>[testCount];
        targetInt = new BytePoint<int>[testCount];
        sourceLong = new BytePoint<long>[testCount];
        targetLong = new BytePoint<long>[testCount];

        for (int i = 0; i < testCount; i++)
        {
            sourceByte[i] = new BytePoint<byte>(BitConverter.GetBytes(r.NextInt64())[0]);
            targetByte[i] = new BytePoint<byte>(BitConverter.GetBytes(r.NextInt64())[0]);
            sourceUShort[i] = new BytePoint<ushort>(BitConverter.ToUInt16(BitConverter.GetBytes(r.NextInt64())));
            targetUShort[i] = new BytePoint<ushort>(BitConverter.ToUInt16(BitConverter.GetBytes(r.NextInt64())));
            sourceUInt[i] = new BytePoint<uint>(BitConverter.ToUInt32(BitConverter.GetBytes(r.NextInt64())));
            targetUInt[i] = new BytePoint<uint>(BitConverter.ToUInt32(BitConverter.GetBytes(r.NextInt64())));
            sourceULong[i] = new BytePoint<ulong>(BitConverter.ToUInt64(BitConverter.GetBytes(r.NextInt64())));
            targetULong[i] = new BytePoint<ulong>(BitConverter.ToUInt64(BitConverter.GetBytes(r.NextInt64())));
            sourceSByte[i] = new BytePoint<sbyte>((sbyte)BitConverter.GetBytes(r.NextInt64())[0]);
            targetSByte[i] = new BytePoint<sbyte>((sbyte)BitConverter.GetBytes(r.NextInt64())[0]);
            sourceShort[i] = new BytePoint<short>(BitConverter.ToInt16(BitConverter.GetBytes(r.NextInt64())));
            targetShort[i] = new BytePoint<short>(BitConverter.ToInt16(BitConverter.GetBytes(r.NextInt64())));
            sourceInt[i] = new BytePoint<int>(BitConverter.ToInt32(BitConverter.GetBytes(r.NextInt64())));
            targetInt[i] = new BytePoint<int>(BitConverter.ToInt32(BitConverter.GetBytes(r.NextInt64())));
            sourceLong[i] = new BytePoint<long>(BitConverter.ToInt64(BitConverter.GetBytes(r.NextInt64())));
            targetLong[i] = new BytePoint<long>(BitConverter.ToInt64(BitConverter.GetBytes(r.NextInt64())));
        }
    }

    [IterationSetup]
    public void IterationSetup()
    {
        Array.Copy(sourceByte, targetByte, testCount);
        Array.Copy(sourceUShort, targetUShort, testCount);
        Array.Copy(sourceUInt, targetUInt, testCount);
        Array.Copy(sourceULong, targetULong, testCount);

        Array.Copy(sourceSByte, targetSByte, testCount);
        Array.Copy(sourceShort, targetShort, testCount);
        Array.Copy(sourceInt, targetInt, testCount);
        Array.Copy(sourceLong, targetLong, testCount);

        GC.Collect();
    }

    [IterationCleanup]
    public void IterationCleanup()
    {
        Array.Clear(targetByte);
        Array.Clear(targetUShort);
        Array.Clear(targetUInt);
        Array.Clear(targetULong);
        Array.Clear(targetSByte);
        Array.Clear(targetShort);
        Array.Clear(targetInt);
        Array.Clear(targetLong);
        GC.Collect();
    }

    [Benchmark(Baseline = true)]
    public void ArraySortByte()
    {
        Array.Sort(targetByte, (l, r) => l.key.CompareTo(r.key));
    }

    [Benchmark]
    public void RadixSortByte()
    {
        LRadixSortByte!.Sort(targetByte);
    }

    [Benchmark]
    public void ArraySortSByte()
    {
        Array.Sort(targetSByte, (l, r) => l.key.CompareTo(r.key));
    }

    [Benchmark]
    public void RadixSortSByte()
    {
        LRadixSortSByte!.Sort(targetSByte);
    }

    [Benchmark]
    public void ArraySortShort()
    {
        Array.Sort(targetShort, (l, r) => l.key.CompareTo(r.key));
    }

    [Benchmark]
    public void RadixSortShort()
    {
        LRadixSortShort!.Sort(targetShort);
    }

    [Benchmark]
    public void ArraySortUShort()
    {
        Array.Sort(targetUShort, (l, r) => l.key.CompareTo(r.key));
    }

    [Benchmark]
    public void RadixSortUShort()
    {
        LRadixSortUShort!.Sort(targetUShort);
    }

    [Benchmark]
    public void ArraySortUInt()
    {
        Array.Sort(targetUInt, (l, r) => l.key.CompareTo(r.key));
    }

    [Benchmark]
    public void RadixSortUInt()
    {
        LRadixSortUInt!.Sort(targetUInt);
    }

    [Benchmark]
    public void ArraySortInt()
    {
        Array.Sort(targetInt, (l, r) => l.key.CompareTo(r.key));
    }

    [Benchmark]
    public void RadixSortInt()
    {
        LRadixSortInt!.Sort(targetInt);
    }

    [Benchmark]
    public void ArraySortULong()
    {
        Array.Sort(targetULong, (l, r) => l.key.CompareTo(r.key));
    }

    [Benchmark]
    public void RadixSortULong()
    {
        LRadixSortULong!.Sort(targetULong);
    }

    [Benchmark]
    public void ArraySortLong()
    {
        Array.Sort(targetLong, (l, r) => l.key.CompareTo(r.key));
    }

    [Benchmark]
    public void RadixSortLong()
    {
        LRadixSortLong!.Sort(targetLong);
    }
}
```
