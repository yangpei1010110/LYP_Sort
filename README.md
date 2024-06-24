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
| ArraySortByte   | 1000      |    155.011 us |  16.6713 us |  1.00 |     400 B |
| RadixSortByte   | 1000      |      9.600 us |   0.2372 us |  0.07 |     400 B |
| ArraySortSByte  | 1000      |    156.691 us |  14.9125 us |  1.04 |     400 B |
| RadixSortSByte  | 1000      |      9.358 us |   0.2201 us |  0.07 |     112 B |
| ArraySortShort  | 1000      |    133.942 us |  22.0519 us |  0.90 |     400 B |
| RadixSortShort  | 1000      |     15.284 us |   0.4964 us |  0.11 |     400 B |
| ArraySortUShort | 1000      |    152.958 us |  18.5704 us |  1.00 |     400 B |
| RadixSortUShort | 1000      |     14.252 us |   0.3221 us |  0.10 |     400 B |
| ArraySortUInt   | 1000      |    180.698 us |  19.9444 us |  1.17 |     400 B |
| RadixSortUInt   | 1000      |     27.891 us |   0.7171 us |  0.21 |     400 B |
| ArraySortInt    | 1000      |    166.159 us |  22.3091 us |  1.19 |     400 B |
| RadixSortInt    | 1000      |     27.304 us |   0.6465 us |  0.19 |     400 B |
| ArraySortULong  | 1000      |    185.318 us |  14.7229 us |  1.31 |     400 B |
| RadixSortULong  | 1000      |     50.896 us |   1.4943 us |  0.37 |     400 B |
| ArraySortLong   | 1000      |    178.932 us |  16.9581 us |  1.19 |     400 B |
| RadixSortLong   | 1000      |     55.187 us |   1.4465 us |  0.42 |      64 B |
|                 |           |               |             |       |           |
| ArraySortByte   | 10000     |    643.454 us |  21.4124 us |  1.00 |     400 B |
| RadixSortByte   | 10000     |     79.840 us |   2.7216 us |  0.13 |     400 B |
| ArraySortSByte  | 10000     |    646.593 us |  23.7900 us |  1.01 |      64 B |
| RadixSortSByte  | 10000     |     73.773 us |   1.8364 us |  0.11 |     400 B |
| ArraySortShort  | 10000     |  1,204.038 us | 245.3156 us |  2.02 |     400 B |
| RadixSortShort  | 10000     |    133.812 us |   3.4734 us |  0.21 |     400 B |
| ArraySortUShort | 10000     |  1,279.659 us | 240.5209 us |  2.14 |     400 B |
| RadixSortUShort | 10000     |    128.183 us |   2.8990 us |  0.20 |     400 B |
| ArraySortUInt   | 10000     |    833.271 us |  16.4968 us |  1.24 |     400 B |
| RadixSortUInt   | 10000     |    243.429 us |   4.8517 us |  0.37 |     400 B |
| ArraySortInt    | 10000     |    821.100 us |  18.8686 us |  1.28 |     400 B |
| RadixSortInt    | 10000     |    238.103 us |   3.9560 us |  0.37 |     400 B |
| ArraySortULong  | 10000     |    833.030 us |  18.4802 us |  1.30 |     400 B |
| RadixSortULong  | 10000     |    441.686 us |   8.6649 us |  0.68 |     400 B |
| ArraySortLong   | 10000     |  1,325.575 us | 252.4700 us |  2.21 |     400 B |
| RadixSortLong   | 10000     |    485.564 us |   8.9001 us |  0.75 |     736 B |
|                 |           |               |             |       |           |
| ArraySortByte   | 100000    |  8,285.196 us | 165.6962 us |  1.00 |     400 B |
| RadixSortByte   | 100000    |  1,574.093 us | 127.2620 us |  0.19 |     400 B |
| ArraySortSByte  | 100000    |  8,363.930 us | 177.4893 us |  1.01 |     400 B |
| RadixSortSByte  | 100000    |  1,667.019 us | 134.5462 us |  0.20 |     400 B |
| ArraySortShort  | 100000    | 10,901.890 us | 215.2203 us |  1.32 |      64 B |
| RadixSortShort  | 100000    |  3,225.430 us | 190.0014 us |  0.39 |     400 B |
| ArraySortUShort | 100000    | 10,788.707 us | 213.4914 us |  1.30 |      64 B |
| RadixSortUShort | 100000    |  2,856.668 us | 163.2455 us |  0.35 |     400 B |
| ArraySortUInt   | 100000    | 11,575.853 us | 223.0105 us |  1.40 |     400 B |
| RadixSortUInt   | 100000    |  4,921.064 us | 178.3648 us |  0.60 |      64 B |
| ArraySortInt    | 100000    | 12,219.817 us | 240.9945 us |  1.47 |     400 B |
| RadixSortInt    | 100000    |  5,493.026 us | 181.3643 us |  0.66 |     400 B |
| ArraySortULong  | 100000    | 12,588.642 us | 250.8855 us |  1.52 |     400 B |
| RadixSortULong  | 100000    | 10,370.970 us | 259.4363 us |  1.26 |     400 B |
| ArraySortLong   | 100000    | 12,207.548 us | 241.0600 us |  1.47 |     400 B |
| RadixSortLong   | 100000    | 10,184.056 us | 222.8663 us |  1.23 |     400 B |
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

    public LRadixSort<BytePoint<byte>, byte>?     LRadixSortByte;
    public LRadixSort<BytePoint<sbyte>, sbyte>?   LRadixSortSByte;
    public LRadixSort<BytePoint<short>, short>?   LRadixSortShort;
    public LRadixSort<BytePoint<ushort>, ushort>? LRadixSortUShort;
    public LRadixSort<BytePoint<int>, int>?       LRadixSortInt;
    public LRadixSort<BytePoint<uint>, uint>?     LRadixSortUInt;
    public LRadixSort<BytePoint<long>, long>?     LRadixSortLong;
    public LRadixSort<BytePoint<ulong>, ulong>?   LRadixSortULong;

    [GlobalSetup]
    public void Setup()
    {
        LRadixSortByte = LRadixSort<BytePoint<byte>, byte>.CreateGeneric(p => p.key, 1_000_000)!;
        LRadixSortSByte = LRadixSort<BytePoint<sbyte>, sbyte>.CreateGeneric(p => p.key, 1_000_000)!;
        LRadixSortShort = LRadixSort<BytePoint<short>, short>.CreateGeneric(p => p.key, 1_000_000)!;
        LRadixSortUShort = LRadixSort<BytePoint<ushort>, ushort>.CreateGeneric(p => p.key, 1_000_000)!;
        LRadixSortInt = LRadixSort<BytePoint<int>, int>.CreateGeneric(p => p.key, 1_000_000)!;
        LRadixSortUInt = LRadixSort<BytePoint<uint>, uint>.CreateGeneric(p => p.key, 1_000_000)!;
        LRadixSortLong = LRadixSort<BytePoint<long>, long>.CreateGeneric(p => p.key, 1_000_000)!;
        LRadixSortULong = LRadixSort<BytePoint<ulong>, ulong>.CreateGeneric(p => p.key, 1_000_000)!;
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
