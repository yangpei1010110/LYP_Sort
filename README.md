Simple Zero Alloc Sort For Unity Game

BenchmarkDotNet:
ValueTypeSort ResultData:
```ValueType
| Method          | testCount | Mean          | Error       | Ratio | Allocated |
|---------------- |---------- |--------------:|------------:|------:|----------:|
| ArraySortByte   | 1000      |     92.316 us |   3.1607 us |  1.00 |     400 B |
| RadixSortByte   | 1000      |      2.003 us |   0.0592 us |  0.02 |     400 B |
| ArraySortSByte  | 1000      |     92.340 us |   2.3265 us |  1.00 |     400 B |
| RadixSortSByte  | 1000      |      2.357 us |   0.0633 us |  0.03 |     400 B |
| ArraySortShort  | 1000      |     99.813 us |   2.4092 us |  1.09 |     400 B |
| RadixSortShort  | 1000      |      4.287 us |   0.1089 us |  0.05 |     400 B |
| ArraySortUShort | 1000      |    110.059 us |   4.8353 us |  1.20 |     400 B |
| RadixSortUShort | 1000      |      3.388 us |   0.0695 us |  0.03 |     400 B |
| ArraySortUInt   | 1000      |     26.863 us |   0.5355 us |  0.28 |     400 B |
| RadixSortUInt   | 1000      |      7.745 us |   0.1543 us |  0.07 |     400 B |
| ArraySortInt    | 1000      |     24.567 us |   0.4907 us |  0.26 |     400 B |
| RadixSortInt    | 1000      |      7.254 us |   0.1435 us |  0.07 |     736 B |
| ArraySortULong  | 1000      |     25.320 us |   0.9732 us |  0.28 |     400 B |
| RadixSortULong  | 1000      |     13.407 us |   0.1849 us |  0.12 |     400 B |
| ArraySortLong   | 1000      |    105.559 us |   3.4343 us |  1.14 |     400 B |
| RadixSortLong   | 1000      |     14.425 us |   0.1352 us |  0.13 |     400 B |
|                 |           |               |             |       |           |
| ArraySortByte   | 10000     |    749.430 us |  14.9416 us |  1.00 |     400 B |
| RadixSortByte   | 10000     |     10.557 us |   0.1229 us |  0.01 |     400 B |
| ArraySortSByte  | 10000     |    783.544 us |  15.6385 us |  1.02 |     400 B |
| RadixSortSByte  | 10000     |     14.493 us |   0.2818 us |  0.02 |     400 B |
| ArraySortShort  | 10000     |  1,050.860 us |  20.7531 us |  1.36 |     400 B |
| RadixSortShort  | 10000     |     29.431 us |   0.2152 us |  0.04 |     400 B |
| ArraySortUShort | 10000     |  1,018.815 us |  20.2030 us |  1.35 |     400 B |
| RadixSortUShort | 10000     |     23.707 us |   0.2361 us |  0.03 |     400 B |
| ArraySortUInt   | 10000     |    412.881 us |   7.9871 us |  0.54 |     400 B |
| RadixSortUInt   | 10000     |     51.612 us |   0.2652 us |  0.07 |     400 B |
| ArraySortInt    | 10000     |    375.531 us |   7.0547 us |  0.48 |     400 B |
| RadixSortInt    | 10000     |     64.442 us |   1.4405 us |  0.09 |     400 B |
| ArraySortULong  | 10000     |    380.486 us |   5.2442 us |  0.49 |     400 B |
| RadixSortULong  | 10000     |    128.793 us |   2.6055 us |  0.17 |     400 B |
| ArraySortLong   | 10000     |  1,012.991 us |  19.9409 us |  1.34 |     400 B |
| RadixSortLong   | 10000     |    124.056 us |   1.8701 us |  0.17 |     400 B |
|                 |           |               |             |       |           |
| ArraySortByte   | 100000    |  6,580.929 us |  63.5968 us |  1.00 |     400 B |
| RadixSortByte   | 100000    |    102.414 us |   2.0392 us |  0.02 |     400 B |
| ArraySortSByte  | 100000    |  7,085.817 us |  48.4800 us |  1.08 |     400 B |
| RadixSortSByte  | 100000    |    128.488 us |   2.5539 us |  0.02 |     400 B |
| ArraySortShort  | 100000    |  4,581.797 us |  58.1471 us |  0.70 |     400 B |
| RadixSortShort  | 100000    |    305.955 us |   6.0176 us |  0.05 |     400 B |
| ArraySortUShort | 100000    |  4,492.193 us |  54.8601 us |  0.68 |     400 B |
| RadixSortUShort | 100000    |    250.256 us |   6.1246 us |  0.04 |     400 B |
| ArraySortUInt   | 100000    |  4,732.900 us |  86.7723 us |  0.72 |     400 B |
| RadixSortUInt   | 100000    |    497.246 us |   3.5297 us |  0.08 |     400 B |
| ArraySortInt    | 100000    |  4,595.312 us |  90.0808 us |  0.70 |     400 B |
| RadixSortInt    | 100000    |    588.643 us |   6.2241 us |  0.09 |     400 B |
| ArraySortULong  | 100000    |  4,620.207 us |  74.1285 us |  0.70 |     400 B |
| RadixSortULong  | 100000    |  1,189.542 us |  22.5069 us |  0.18 |     400 B |
| ArraySortLong   | 100000    |  4,500.824 us |  43.5068 us |  0.68 |     400 B |
| RadixSortLong   | 100000    |  1,281.156 us |  25.4159 us |  0.20 |     400 B |
|                 |           |               |             |       |           |
| ArraySortByte   | 1000000   | 28,231.340 us | 132.1395 us |  1.00 |     112 B |
| RadixSortByte   | 1000000   |  1,061.130 us |  20.9400 us |  0.04 |     400 B |
| ArraySortSByte  | 1000000   | 27,211.513 us | 159.9469 us |  0.96 |     400 B |
| RadixSortSByte  | 1000000   |  1,274.636 us |  14.4537 us |  0.05 |     400 B |
| ArraySortShort  | 1000000   | 50,068.547 us | 283.9253 us |  1.77 |     400 B |
| RadixSortShort  | 1000000   |  3,051.777 us |  60.3984 us |  0.11 |     400 B |
| ArraySortUShort | 1000000   | 49,805.600 us | 194.5977 us |  1.76 |     400 B |
| RadixSortUShort | 1000000   |  2,788.526 us |  68.2300 us |  0.10 |     400 B |
| ArraySortUInt   | 1000000   | 54,644.680 us | 396.3841 us |  1.94 |     400 B |
| RadixSortUInt   | 1000000   |  6,485.965 us | 244.1297 us |  0.24 |      64 B |
| ArraySortInt    | 1000000   | 55,965.286 us | 125.0064 us |  1.98 |     400 B |
| RadixSortInt    | 1000000   |  6,618.903 us | 281.7887 us |  0.23 |     400 B |
| ArraySortULong  | 1000000   | 56,444.267 us | 213.7936 us |  2.00 |     400 B |
| RadixSortULong  | 1000000   | 16,430.327 us | 724.1072 us |  0.63 |     400 B |
| ArraySortLong   | 1000000   | 54,792.475 us | 205.1885 us |  1.94 |     400 B |
| RadixSortLong   | 1000000   | 17,174.887 us | 630.7734 us |  0.63 |     400 B |
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
        LRadixSortByte = LRadixSort<byte,byte>.CreateNonGeneric<byte>( 1_000_000)!;
        LRadixSortSByte = LRadixSort<sbyte, sbyte>.CreateNonGeneric<sbyte>( 1_000_000)!;
        LRadixSortShort = LRadixSort<short, short>.CreateNonGeneric<short>( 1_000_000)!;
        LRadixSortUShort = LRadixSort<ushort, ushort>.CreateNonGeneric<ushort>( 1_000_000)!;
        LRadixSortInt = LRadixSort<int, int>.CreateNonGeneric<int>( 1_000_000)!;
        LRadixSortUInt = LRadixSort<uint, uint>.CreateNonGeneric<uint>( 1_000_000)!;
        LRadixSortLong = LRadixSort<long, long>.CreateNonGeneric<long>( 1_000_000)!;
        LRadixSortULong = LRadixSort<ulong, ulong>.CreateNonGeneric<ulong>( 1_000_000)!;
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
