Simple Zero Alloc Sort For Unity Game

BenchmarkDotNet:
ValueTypeSort ResultData:
```ValueType
| Method          | testCount | Mean          | Error       | Ratio | Allocated |
|---------------- |---------- |--------------:|------------:|------:|----------:|
| ArraySortByte   | 1000      |    101.948 us |   2.0241 us |  1.00 |     400 B |
| RadixSortByte   | 1000      |      4.275 us |   0.0885 us |  0.04 |     400 B |
| ArraySortSByte  | 1000      |     92.647 us |   2.6900 us |  0.91 |     400 B |
| RadixSortSByte  | 1000      |      4.489 us |   0.0946 us |  0.04 |     400 B |
| ArraySortShort  | 1000      |     97.100 us |   1.9454 us |  0.95 |     400 B |
| RadixSortShort  | 1000      |      7.744 us |   0.1578 us |  0.07 |     400 B |
| ArraySortUShort | 1000      |    100.514 us |   3.0368 us |  0.99 |     400 B |
| RadixSortUShort | 1000      |      7.908 us |   0.0660 us |  0.07 |     400 B |
| ArraySortUInt   | 1000      |     27.331 us |   0.6503 us |  0.27 |     400 B |
| RadixSortUInt   | 1000      |     16.172 us |   0.3234 us |  0.15 |     400 B |
| ArraySortInt    | 1000      |     24.776 us |   0.6402 us |  0.24 |     400 B |
| RadixSortInt    | 1000      |     14.731 us |   0.1134 us |  0.14 |     400 B |
| ArraySortULong  | 1000      |     23.909 us |   0.5832 us |  0.23 |     400 B |
| RadixSortULong  | 1000      |     32.008 us |   0.3642 us |  0.30 |     400 B |
| ArraySortLong   | 1000      |     98.818 us |   3.3944 us |  0.97 |     400 B |
| RadixSortLong   | 1000      |     31.092 us |   0.3332 us |  0.29 |     400 B |
|                 |           |               |             |       |           |
| ArraySortByte   | 10000     |    754.725 us |  14.9322 us |  1.00 |     400 B |
| RadixSortByte   | 10000     |     34.008 us |   0.6773 us |  0.04 |     400 B |
| ArraySortSByte  | 10000     |    769.721 us |  15.0281 us |  1.02 |     400 B |
| RadixSortSByte  | 10000     |     35.788 us |   0.6953 us |  0.05 |     400 B |
| ArraySortShort  | 10000     |  1,010.013 us |  18.7888 us |  1.33 |     400 B |
| RadixSortShort  | 10000     |     70.572 us |   1.3596 us |  0.09 |     400 B |
| ArraySortUShort | 10000     |    996.673 us |  19.7745 us |  1.32 |     400 B |
| RadixSortUShort | 10000     |     61.589 us |   1.2273 us |  0.08 |     400 B |
| ArraySortUInt   | 10000     |    384.193 us |   7.3952 us |  0.51 |     400 B |
| RadixSortUInt   | 10000     |    141.186 us |   2.6859 us |  0.19 |     400 B |
| ArraySortInt    | 10000     |    374.408 us |   4.3751 us |  0.49 |     400 B |
| RadixSortInt    | 10000     |    140.964 us |   2.3155 us |  0.18 |     400 B |
| ArraySortULong  | 10000     |    384.464 us |   6.6107 us |  0.50 |     400 B |
| RadixSortULong  | 10000     |    273.995 us |   5.3794 us |  0.36 |     400 B |
| ArraySortLong   | 10000     |  1,023.169 us |  18.5153 us |  1.34 |     400 B |
| RadixSortLong   | 10000     |    270.221 us |   3.4256 us |  0.35 |     400 B |
|                 |           |               |             |       |           |
| ArraySortByte   | 100000    |  6,722.227 us | 129.6881 us |  1.00 |     400 B |
| RadixSortByte   | 100000    |    366.132 us |   8.5298 us |  0.05 |     400 B |
| ArraySortSByte  | 100000    |  7,172.521 us |  81.6025 us |  1.07 |     400 B |
| RadixSortSByte  | 100000    |    357.647 us |   7.0155 us |  0.05 |     400 B |
| ArraySortShort  | 100000    | 10,735.120 us |  89.5631 us |  1.60 |     400 B |
| RadixSortShort  | 100000    |    636.900 us |   6.1406 us |  0.09 |     400 B |
| ArraySortUShort | 100000    |  4,542.562 us |  50.9345 us |  0.68 |     400 B |
| RadixSortUShort | 100000    |    592.136 us |   3.4046 us |  0.09 |     400 B |
| ArraySortUInt   | 100000    |  4,761.027 us |  51.6166 us |  0.71 |     400 B |
| RadixSortUInt   | 100000    |  1,240.337 us |  21.3392 us |  0.18 |     400 B |
| ArraySortInt    | 100000    |  4,520.992 us |  35.7348 us |  0.67 |     400 B |
| RadixSortInt    | 100000    |  1,337.186 us |  21.5148 us |  0.20 |     400 B |
| ArraySortULong  | 100000    |  4,659.579 us |  85.6355 us |  0.69 |     400 B |
| RadixSortULong  | 100000    |  2,654.021 us |  26.7270 us |  0.39 |     400 B |
| ArraySortLong   | 100000    |  4,560.487 us |  32.9248 us |  0.68 |     400 B |
| RadixSortLong   | 100000    |  2,655.550 us |  42.4351 us |  0.39 |     400 B |
|                 |           |               |             |       |           |
| ArraySortByte   | 1000000   | 28,116.440 us | 158.4369 us |  1.00 |     400 B |
| RadixSortByte   | 1000000   |  3,681.421 us |  64.8467 us |  0.13 |     400 B |
| ArraySortSByte  | 1000000   | 28,257.873 us | 131.8973 us |  1.01 |     400 B |
| RadixSortSByte  | 1000000   |  3,143.533 us |  57.9743 us |  0.12 |     400 B |
| ArraySortShort  | 1000000   | 50,180.840 us | 275.4863 us |  1.78 |     400 B |
| RadixSortShort  | 1000000   |  6,353.150 us | 111.8125 us |  0.23 |     400 B |
| ArraySortUShort | 1000000   | 49,534.317 us | 344.4022 us |  1.76 |     400 B |
| RadixSortUShort | 1000000   |  5,890.538 us |  73.1542 us |  0.21 |     400 B |
| ArraySortUInt   | 1000000   | 54,548.915 us | 168.0500 us |  1.94 |     400 B |
| RadixSortUInt   | 1000000   | 13,076.892 us | 247.6614 us |  0.48 |     400 B |
| ArraySortInt    | 1000000   | 56,337.271 us | 399.2961 us |  2.00 |     400 B |
| RadixSortInt    | 1000000   | 13,002.584 us | 259.2232 us |  0.46 |     400 B |
| ArraySortULong  | 1000000   | 56,282.279 us | 169.8987 us |  2.00 |     400 B |
| RadixSortULong  | 1000000   | 26,886.729 us | 532.4444 us |  0.96 |     400 B |
| ArraySortLong   | 1000000   | 55,262.893 us | 294.6417 us |  1.97 |     400 B |
| RadixSortLong   | 1000000   | 28,740.412 us | 560.8498 us |  1.02 |     400 B |
```
ValueTypeSort TestCode:
```csharp
using BenchmarkDotNet.Attributes;
using LYP_Sort.LSortLib.LRadixSort;

namespace LYP_Sort_Test;

[MemoryDiagnoser]
public class BenchmarkSortWithValueType
{
    public class BytePoint
    {
        public int index;
        public int value;

        public BytePoint(int index, int value)
        {
            this.index = index;
            this.value = value;
        }
    }

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


    public LRadixSort<byte, byte>?     LRadixSortByte;
    public LRadixSort<sbyte, sbyte>?   LRadixSortSByte;
    public LRadixSort<short, short>?   LRadixSortShort;
    public LRadixSort<ushort, ushort>? LRadixSortUShort;
    public LRadixSort<int, int>?       LRadixSortInt;
    public LRadixSort<uint, uint>?     LRadixSortUInt;
    public LRadixSort<long, long>?     LRadixSortLong;
    public LRadixSort<ulong, ulong>?   LRadixSortULong;

    [GlobalSetup]
    public void Setup()
    {
        LRadixSortByte = LRadixSort<byte, byte>.CreateGeneric(p => p, 1_000_000)!;
        LRadixSortSByte = LRadixSort<sbyte, sbyte>.CreateGeneric(p => p, 1_000_000)!;
        LRadixSortShort = LRadixSort<short, short>.CreateGeneric(p => p, 1_000_000)!;
        LRadixSortUShort = LRadixSort<ushort, ushort>.CreateGeneric(p => p, 1_000_000)!;
        LRadixSortInt = LRadixSort<int, int>.CreateGeneric(p => p, 1_000_000)!;
        LRadixSortUInt = LRadixSort<uint, uint>.CreateGeneric(p => p, 1_000_000)!;
        LRadixSortLong = LRadixSort<long, long>.CreateGeneric(p => p, 1_000_000)!;
        LRadixSortULong = LRadixSort<ulong, ulong>.CreateGeneric(p => p, 1_000_000)!;
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
