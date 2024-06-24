Simple Zero Alloc Sort For Unity Game

BenchmarkDotNet:
ValueTypeSort ResultData:
```ValueType
| Method          | testCount | Mean          | Allocated |
|---------------- |---------- |--------------:|----------:|
| BaseSortByte    | 1000      |     96.916 us |     400 B |
| BaseSortSByte   | 1000      |     90.031 us |     400 B |
| BaseSortUShort  | 1000      |     99.035 us |     400 B |
| BaseSortUInt    | 1000      |     29.631 us |     400 B |
| BaseSortULong   | 1000      |     28.677 us |     400 B |
| BaseSortShort   | 1000      |    101.442 us |     400 B |
| BaseSortInt     | 1000      |     25.886 us |     400 B |
| BaseSortLong    | 1000      |    106.840 us |     400 B |
| RadixSortByte   | 1000      |      4.111 us |     400 B |
| RadixSortUShort | 1000      |      8.653 us |     400 B |
| RadixSortUInt   | 1000      |     14.941 us |     400 B |
| RadixSortULong  | 1000      |     33.207 us |     400 B |
| RadixSortSByte  | 1000      |      4.296 us |     400 B |
| RadixSortShort  | 1000      |      8.258 us |     400 B |
| RadixSortInt    | 1000      |     14.669 us |     400 B |
| RadixSortLong   | 1000      |     34.869 us |     400 B |
|                 |           |               |           |
| BaseSortByte    | 10000     |    754.516 us |     400 B |
| BaseSortSByte   | 10000     |    788.470 us |     400 B |
| BaseSortUShort  | 10000     |  1,064.618 us |     400 B |
| BaseSortUInt    | 10000     |    385.536 us |     400 B |
| BaseSortULong   | 10000     |    377.729 us |     400 B |
| BaseSortShort   | 10000     |  1,044.839 us |     400 B |
| BaseSortInt     | 10000     |    381.273 us |     400 B |
| BaseSortLong    | 10000     |    996.826 us |     400 B |
| RadixSortByte   | 10000     |     37.757 us |     400 B |
| RadixSortUShort | 10000     |     68.600 us |     400 B |
| RadixSortUInt   | 10000     |    128.462 us |     400 B |
| RadixSortULong  | 10000     |    293.292 us |     400 B |
| RadixSortSByte  | 10000     |     33.012 us |     400 B |
| RadixSortShort  | 10000     |     67.968 us |     400 B |
| RadixSortInt    | 10000     |    147.261 us |     400 B |
| RadixSortLong   | 10000     |    279.783 us |     400 B |
|                 |           |               |           |
| BaseSortByte    | 100000    |  6,751.137 us |     400 B |
| BaseSortSByte   | 100000    |  7,136.613 us |     400 B |
| BaseSortUShort  | 100000    | 10,640.107 us |     400 B |
| BaseSortUInt    | 100000    |  4,800.664 us |     112 B |
| BaseSortULong   | 100000    |  4,726.790 us |     400 B |
| BaseSortShort   | 100000    |  4,605.870 us |     400 B |
| BaseSortInt     | 100000    |  4,580.354 us |     400 B |
| BaseSortLong    | 100000    |  4,572.871 us |     400 B |
| RadixSortByte   | 100000    |    339.502 us |     400 B |
| RadixSortUShort | 100000    |    670.940 us |     400 B |
| RadixSortUInt   | 100000    |  1,234.653 us |      64 B |
| RadixSortULong  | 100000    |  2,902.732 us |     400 B |
| RadixSortSByte  | 100000    |    324.665 us |     400 B |
| RadixSortShort  | 100000    |    639.462 us |     400 B |
| RadixSortInt    | 100000    |  1,257.133 us |     400 B |
| RadixSortLong   | 100000    |  2,744.644 us |      64 B |
|                 |           |               |           |
| BaseSortByte    | 1000000   | 27,673.200 us |     400 B |
| BaseSortSByte   | 1000000   | 26,959.243 us |     400 B |
| BaseSortUShort  | 1000000   | 49,114.993 us |     400 B |
| BaseSortUInt    | 1000000   | 54,662.686 us |     400 B |
| BaseSortULong   | 1000000   | 56,354.200 us |     400 B |
| BaseSortShort   | 1000000   | 52,740.043 us |     400 B |
| BaseSortInt     | 1000000   | 56,378.454 us |     736 B |
| BaseSortLong    | 1000000   | 54,631.587 us |     400 B |
| RadixSortByte   | 1000000   |  3,344.583 us |     400 B |
| RadixSortUShort | 1000000   |  6,458.164 us |     400 B |
| RadixSortUInt   | 1000000   | 12,612.450 us |     400 B |
| RadixSortULong  | 1000000   | 26,223.667 us |     400 B |
| RadixSortSByte  | 1000000   |  3,241.593 us |     400 B |
| RadixSortShort  | 1000000   |  6,354.000 us |     400 B |
| RadixSortInt    | 1000000   | 12,764.746 us |     400 B |
| RadixSortLong   | 1000000   | 26,511.900 us |     400 B |
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
    public void BaseSortByte()
    {
        Array.Sort(targetByte);
    }

    [Benchmark]
    public void BaseSortSByte()
    {
        Array.Sort(targetSByte);
    }

    [Benchmark]
    public void BaseSortUShort()
    {
        Array.Sort(targetUShort);
    }

    [Benchmark]
    public void BaseSortUInt()
    {
        Array.Sort(targetUInt);
    }

    [Benchmark]
    public void BaseSortULong()
    {
        Array.Sort(targetULong);
    }

    [Benchmark]
    public void BaseSortShort()
    {
        Array.Sort(targetShort);
    }

    [Benchmark]
    public void BaseSortInt()
    {
        Array.Sort(targetInt);
    }

    [Benchmark]
    public void BaseSortLong()
    {
        Array.Sort(targetLong);
    }

    [Benchmark]
    public void RadixSortByte()
    {
        LRadixSortByte!.Sort(targetByte);
    }

    [Benchmark]
    public void RadixSortUShort()
    {
        LRadixSortUShort!.Sort(targetUShort);
    }

    [Benchmark]
    public void RadixSortUInt()
    {
        LRadixSortUInt!.Sort(targetUInt);
    }

    [Benchmark]
    public void RadixSortULong()
    {
        LRadixSortULong!.Sort(targetULong);
    }

    [Benchmark]
    public void RadixSortSByte()
    {
        LRadixSortSByte!.Sort(targetSByte);
    }

    [Benchmark]
    public void RadixSortShort()
    {
        LRadixSortShort!.Sort(targetShort);
    }

    [Benchmark]
    public void RadixSortInt()
    {
        LRadixSortInt!.Sort(targetInt);
    }

    [Benchmark]
    public void RadixSortLong()
    {
        LRadixSortLong!.Sort(targetLong);
    }
}
```
