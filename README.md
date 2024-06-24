Simple Zero Alloc Sort For Unity Game

BenchmarkDotNet:

| Method          | testCount | Mean           | Error         | StdDev         | Median         | Ratio | RatioSD | Allocated | Alloc Ratio |
|---------------- |---------- |---------------:|--------------:|---------------:|---------------:|------:|--------:|----------:|------------:|
| BaseSortByte    | 1000      |      84.238 us |    10.9232 us |     32.2072 us |      93.350 us |  1.00 |    0.00 |     400 B |        1.00 |
| BaseSortSByte   | 1000      |      96.006 us |     3.8240 us |     10.9719 us |      93.700 us |  1.38 |    0.87 |     400 B |        1.00 |
| BaseSortUShort  | 1000      |      96.213 us |     8.9864 us |     26.3556 us |     100.600 us |  1.30 |    0.75 |     400 B |        1.00 |
| BaseSortUInt    | 1000      |      29.920 us |     0.7209 us |      2.1028 us |      29.800 us |  0.46 |    0.31 |     400 B |        1.00 |
| BaseSortULong   | 1000      |      30.110 us |     1.3446 us |      3.6121 us |      29.250 us |  0.37 |    0.22 |     400 B |        1.00 |
| BaseSortShort   | 1000      |      97.660 us |     6.6070 us |     19.0626 us |      98.750 us |  1.37 |    0.84 |     400 B |        1.00 |
| BaseSortInt     | 1000      |      27.168 us |     0.6519 us |      1.7845 us |      26.550 us |  0.36 |    0.23 |     400 B |        1.00 |
| BaseSortLong    | 1000      |      98.913 us |     6.1619 us |     17.0746 us |     100.700 us |  1.24 |    0.67 |     400 B |        1.00 |
| BaseSortBP      | 1000      |      74.500 us |     1.2694 us |      1.3582 us |      74.400 us |  0.64 |    0.05 |     400 B |        1.00 |
| RadixSortByte   | 1000      |       4.662 us |     0.1176 us |      0.3279 us |       4.600 us |  0.06 |    0.04 |     400 B |        1.00 |
| RadixSortUShort | 1000      |       7.150 us |     0.1369 us |      0.1465 us |       7.100 us |  0.06 |    0.00 |     400 B |        1.00 |
| RadixSortUInt   | 1000      |      14.967 us |     0.3008 us |      0.2348 us |      15.000 us |  0.12 |    0.01 |     400 B |        1.00 |
| RadixSortULong  | 1000      |      30.916 us |     0.6052 us |      0.6727 us |      30.900 us |  0.27 |    0.02 |     400 B |        1.00 |
| RadixSortSByte  | 1000      |       4.820 us |     0.0985 us |      0.2322 us |       4.800 us |  0.05 |    0.01 |     112 B |        0.28 |
| RadixSortShort  | 1000      |       8.229 us |     0.1664 us |      0.3323 us |       8.200 us |  0.08 |    0.01 |     400 B |        1.00 |
| RadixSortInt    | 1000      |      16.291 us |     0.2686 us |      0.6225 us |      16.100 us |  0.16 |    0.02 |     400 B |        1.00 |
| RadixSortLong   | 1000      |      31.469 us |     0.4245 us |      0.3545 us |      31.400 us |  0.26 |    0.02 |     400 B |        1.00 |
| RadixSortBP     | 1000      |      26.028 us |     0.7690 us |      2.2310 us |      25.800 us |  0.39 |    0.26 |     400 B |        1.00 |
|                 |           |                |               |                |                |       |         |           |             |
| BaseSortByte    | 10000     |     738.357 us |    14.7542 us |     27.3479 us |     730.450 us |  1.00 |    0.00 |     400 B |        1.00 |
| BaseSortSByte   | 10000     |     773.606 us |    15.4216 us |     15.8368 us |     775.400 us |  1.02 |    0.02 |     400 B |        1.00 |
| BaseSortUShort  | 10000     |     986.639 us |    19.4983 us |     20.8630 us |     984.300 us |  1.30 |    0.03 |     112 B |        0.28 |
| BaseSortUInt    | 10000     |     392.853 us |     7.6822 us |     11.4984 us |     392.250 us |  0.53 |    0.02 |     400 B |        1.00 |
| BaseSortULong   | 10000     |     380.262 us |     5.5664 us |      4.6482 us |     378.300 us |  0.50 |    0.01 |     400 B |        1.00 |
| BaseSortShort   | 10000     |     999.567 us |    19.3238 us |     27.0892 us |     988.800 us |  1.34 |    0.04 |     400 B |        1.00 |
| BaseSortInt     | 10000     |     376.032 us |     7.3460 us |      7.5438 us |     374.750 us |  0.50 |    0.02 |     400 B |        1.00 |
| BaseSortLong    | 10000     |   1,028.940 us |    20.2431 us |     18.9354 us |   1,028.500 us |  1.35 |    0.03 |     400 B |        1.00 |
| BaseSortBP      | 10000     |     955.300 us |    13.3663 us |     10.4355 us |     953.550 us |  1.24 |    0.03 |     400 B |        1.00 |
| RadixSortByte   | 10000     |      34.799 us |     0.8559 us |      2.4418 us |      34.500 us |  0.05 |    0.00 |     400 B |        1.00 |
| RadixSortUShort | 10000     |      59.231 us |     0.5730 us |      0.4785 us |      59.400 us |  0.08 |    0.00 |     400 B |        1.00 |
| RadixSortUInt   | 10000     |     127.662 us |     2.1223 us |      1.7723 us |     128.300 us |  0.17 |    0.00 |     400 B |        1.00 |
| RadixSortULong  | 10000     |     272.452 us |     5.1951 us |      6.5701 us |     272.600 us |  0.36 |    0.01 |     400 B |        1.00 |
| RadixSortSByte  | 10000     |      37.236 us |     0.7436 us |      1.4503 us |      37.000 us |  0.05 |    0.00 |     400 B |        1.00 |
| RadixSortShort  | 10000     |      64.859 us |     1.2899 us |      2.0830 us |      64.050 us |  0.09 |    0.00 |     400 B |        1.00 |
| RadixSortInt    | 10000     |     139.400 us |     2.7224 us |      4.6960 us |     139.450 us |  0.19 |    0.01 |     112 B |        0.28 |
| RadixSortLong   | 10000     |     272.654 us |     4.1350 us |      3.4529 us |     271.600 us |  0.35 |    0.01 |     400 B |        1.00 |
| RadixSortBP     | 10000     |     211.872 us |     4.0298 us |      6.7328 us |     211.350 us |  0.29 |    0.01 |     400 B |        1.00 |
|                 |           |                |               |                |                |       |         |           |             |
| BaseSortByte    | 100000    |   2,832.830 us |    31.1783 us |     70.3746 us |   2,810.000 us |  1.00 |    0.00 |     400 B |        1.00 |
| BaseSortSByte   | 100000    |   2,815.590 us |    55.9462 us |     99.4444 us |   2,782.300 us |  0.99 |    0.04 |     400 B |        1.00 |
| BaseSortUShort  | 100000    |   4,613.420 us |    89.8643 us |     84.0591 us |   4,589.500 us |  1.62 |    0.05 |     400 B |        1.00 |
| BaseSortUInt    | 100000    |   4,640.804 us |    82.1244 us |    115.1270 us |   4,640.800 us |  1.63 |    0.05 |     400 B |        1.00 |
| BaseSortULong   | 100000    |   4,809.786 us |    78.5892 us |    145.6702 us |   4,781.400 us |  1.70 |    0.06 |     400 B |        1.00 |
| BaseSortShort   | 100000    |   4,485.811 us |    46.9905 us |     52.2298 us |   4,481.900 us |  1.58 |    0.04 |      64 B |        0.16 |
| BaseSortInt     | 100000    |   4,659.444 us |    73.9243 us |     79.0982 us |   4,684.200 us |  1.64 |    0.04 |     400 B |        1.00 |
| BaseSortLong    | 100000    |   4,662.274 us |    67.6522 us |     75.1953 us |   4,686.400 us |  1.64 |    0.05 |     400 B |        1.00 |
| BaseSortBP      | 100000    |  10,358.726 us |   198.3161 us |    250.8064 us |  10,262.200 us |  3.63 |    0.15 |     400 B |        1.00 |
| RadixSortByte   | 100000    |     364.894 us |     8.9159 us |     26.2888 us |     361.000 us |  0.13 |    0.01 |     400 B |        1.00 |
| RadixSortUShort | 100000    |     596.908 us |     7.5538 us |      6.3077 us |     596.600 us |  0.21 |    0.01 |     400 B |        1.00 |
| RadixSortUInt   | 100000    |   1,249.216 us |    24.8530 us |     33.1781 us |   1,244.500 us |  0.44 |    0.02 |     400 B |        1.00 |
| RadixSortULong  | 100000    |   2,741.952 us |    54.2401 us |     99.1812 us |   2,705.300 us |  0.97 |    0.03 |     400 B |        1.00 |
| RadixSortSByte  | 100000    |     338.348 us |     7.4543 us |     21.5073 us |     334.900 us |  0.12 |    0.01 |     400 B |        1.00 |
| RadixSortShort  | 100000    |     637.769 us |     9.8476 us |      8.2232 us |     637.000 us |  0.22 |    0.00 |     400 B |        1.00 |
| RadixSortInt    | 100000    |   1,337.858 us |    12.8059 us |     19.5560 us |   1,339.400 us |  0.47 |    0.02 |     400 B |        1.00 |
| RadixSortLong   | 100000    |   2,714.510 us |    53.7154 us |     61.8587 us |   2,702.300 us |  0.95 |    0.04 |     400 B |        1.00 |
| RadixSortBP     | 100000    |   2,444.058 us |    85.1500 us |    251.0666 us |   2,348.250 us |  0.86 |    0.09 |     400 B |        1.00 |
|                 |           |                |               |                |                |       |         |           |             |
| BaseSortByte    | 1000000   |  27,962.933 us |   154.8975 us |    144.8912 us |  27,942.700 us |  1.00 |    0.00 |     400 B |        1.00 |
| BaseSortSByte   | 1000000   |  27,606.683 us |    69.3996 us |     54.1826 us |  27,607.750 us |  0.99 |    0.01 |     400 B |        1.00 |
| BaseSortUShort  | 1000000   |  49,620.693 us |   293.9572 us |    274.9678 us |  49,568.700 us |  1.77 |    0.01 |     400 B |        1.00 |
| BaseSortUInt    | 1000000   |  53,968.521 us |   589.7146 us |    522.7666 us |  53,922.550 us |  1.93 |    0.03 |     400 B |        1.00 |
| BaseSortULong   | 1000000   |  55,822.910 us |   427.3758 us |    399.7676 us |  55,723.750 us |  2.00 |    0.02 |     400 B |        1.00 |
| BaseSortShort   | 1000000   |  49,942.110 us |   294.6004 us |    275.5694 us |  49,933.350 us |  1.79 |    0.01 |     400 B |        1.00 |
| BaseSortInt     | 1000000   |  56,303.557 us |   285.3057 us |    252.9161 us |  56,253.400 us |  2.01 |    0.02 |     400 B |        1.00 |
| BaseSortLong    | 1000000   |  54,209.640 us |   350.2753 us |    327.6477 us |  54,163.200 us |  1.94 |    0.01 |     400 B |        1.00 |
| BaseSortBP      | 1000000   | 186,619.871 us | 3,558.2132 us |  3,954.9446 us | 186,296.050 us |  6.66 |    0.15 |     400 B |        1.00 |
| RadixSortByte   | 1000000   |   3,124.614 us |    61.8695 us |    101.6534 us |   3,148.000 us |  0.11 |    0.00 |     400 B |        1.00 |
| RadixSortUShort | 1000000   |   6,559.804 us |   130.5711 us |    183.0424 us |   6,552.600 us |  0.24 |    0.01 |     400 B |        1.00 |
| RadixSortUInt   | 1000000   |  12,431.079 us |   223.4925 us |    198.1203 us |  12,410.850 us |  0.44 |    0.01 |     400 B |        1.00 |
| RadixSortULong  | 1000000   |  26,791.043 us |   535.2723 us |  1,044.0075 us |  27,131.800 us |  0.95 |    0.04 |     400 B |        1.00 |
| RadixSortSByte  | 1000000   |   3,309.647 us |    64.7415 us |    111.6759 us |   3,321.000 us |  0.12 |    0.00 |     400 B |        1.00 |
| RadixSortShort  | 1000000   |   6,342.311 us |   125.8232 us |    134.6294 us |   6,316.750 us |  0.23 |    0.01 |     400 B |        1.00 |
| RadixSortInt    | 1000000   |  12,622.322 us |   248.4400 us |    265.8280 us |  12,522.550 us |  0.45 |    0.01 |     400 B |        1.00 |
| RadixSortLong   | 1000000   |  27,290.333 us |   539.5648 us |    959.0760 us |  27,416.300 us |  0.99 |    0.03 |      64 B |        0.16 |
| RadixSortBP     | 1000000   | 108,543.029 us | 4,208.0300 us | 12,407.4715 us | 108,719.150 us |  3.90 |    0.28 |     112 B |        0.28 |

```csharp
using BenchmarkDotNet.Attributes;
using LYP_Sort.LSortLib.LRadixSort.Generic;

namespace LYP_Sort_Test;

[MemoryDiagnoser]
public class BenchmarkSortWithByte
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

    public BytePoint[] sourceBP = Array.Empty<BytePoint>();
    public BytePoint[] targetBP = Array.Empty<BytePoint>();

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


    public LRadixSortGeneric<byte, byte> LRadixSortByte =
        LRadixSortGeneric<byte, byte>.Create(p => p, 1_000_000)!;
    public LRadixSortGeneric<sbyte, sbyte> LRadixSortSByte =
        LRadixSortGeneric<sbyte, sbyte>.Create(p => p, 1_000_000)!;
    public LRadixSortGeneric<short, short> LRadixSortShort =
        LRadixSortGeneric<short, short>.Create(p => p, 1_000_000)!;
    public LRadixSortGeneric<ushort, ushort> LRadixSortUShort =
        LRadixSortGeneric<ushort, ushort>.Create(p => p, 1_000_000)!;
    public LRadixSortGeneric<int, int> LRadixSortInt =
        LRadixSortGeneric<int, int>.Create(p => p, 1_000_000)!;
    public LRadixSortGeneric<uint, uint> LRadixSortUInt =
        LRadixSortGeneric<uint, uint>.Create(p => p, 1_000_000)!;
    public LRadixSortGeneric<long, long> LRadixSortLong =
        LRadixSortGeneric<long, long>.Create(p => p, 1_000_000)!;
    public LRadixSortGeneric<ulong, ulong> LRadixSortULong =
        LRadixSortGeneric<ulong, ulong>.Create(p => p, 1_000_000)!;
    public LRadixSortGeneric<BytePoint, int> LRadixSortBP =
        LRadixSortGeneric<BytePoint, int>.Create(p => p.index, 1_000_000)!;

    [GlobalSetup]
    public void Setup()
    {
        Random r = new();
        sourceBP = new BytePoint[testCount];
        targetBP = new BytePoint[testCount];

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
            sourceBP[i] = new BytePoint(r.Next(), r.Next());
            targetBP[i] = new BytePoint(0, 0);

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
        for (int i = 0; i < sourceBP.Length; i++)
        {
            targetBP[i].index = sourceBP[i].index;
            targetBP[i].value = sourceBP[i].value;
        }

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
        for (int i = 0; i < targetBP.Length; i++)
        {
            targetBP[i].index = 0;
            targetBP[i].value = 0;
        }

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
    public void BaseSortBP()
    {
        Array.Sort(targetBP, (l, r) => l.index.CompareTo(r.index));
    }

    [Benchmark]
    public void RadixSortByte()
    {
        LRadixSortByte.Sort(targetByte);
    }

    [Benchmark]
    public void RadixSortUShort()
    {
        LRadixSortUShort.Sort(targetUShort);
    }

    [Benchmark]
    public void RadixSortUInt()
    {
        LRadixSortUInt.Sort(targetUInt);
    }

    [Benchmark]
    public void RadixSortULong()
    {
        LRadixSortULong.Sort(targetULong);
    }

    [Benchmark]
    public void RadixSortSByte()
    {
        LRadixSortSByte.Sort(targetSByte);
    }

    [Benchmark]
    public void RadixSortShort()
    {
        LRadixSortShort.Sort(targetShort);
    }

    [Benchmark]
    public void RadixSortInt()
    {
        LRadixSortInt.Sort(targetInt);
    }

    [Benchmark]
    public void RadixSortLong()
    {
        LRadixSortLong.Sort(targetLong);
    }

    [Benchmark]
    public void RadixSortBP()
    {
        LRadixSortBP.Sort(targetBP);
    }
}
```
