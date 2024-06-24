using System;

namespace MyUtils.LSortLib.LRadixSort.ValueType
{
    public class LRadixSortDouble : LRadixSort<double>
    {
        public new static LRadixSortLong Shared = new LRadixSortLong();
        private           double[]       _buffer;

        public LRadixSortDouble(int initBufferSize = 0) =>
            _buffer = new double[Clamp(initBufferSize, 0, int.MaxValue)];

        public override void Sort(double[] source)
        {
            if (_buffer.Length < source.Length)
            {
                Array.Resize(ref _buffer, source.Length);
            }

            int length = source.Length;
            RadixSortSequential(0, source, _buffer, length);
            RadixSortSequential(1, _buffer, source, length);
            RadixSortSequential(2, source, _buffer, length);
            RadixSortSequential(3, _buffer, source, length);
            RadixSortSequential(4, source, _buffer, length);
            RadixSortSequential(5, _buffer, source, length);
            RadixSortSequential(6, source, _buffer, length);
            RadixSortSequential(7, _buffer, source, length);
        }

        private void RadixSortSequential(byte byteIndex, double[] source, double[] dest, int length)
        {
            Array.Clear(countArr, 0, countArr.Length);
            int byteOffset = byteIndex * 8;

            for (int i = 0; i < length; i++)
            {
                long l = BitConverter.DoubleToInt64Bits(source[i]);
                byte index = (byte)((LongToULong(l) >> byteOffset) & 0xFF);
                countArr[index] += 1;
            }


            offsetArr[0] = 0;
            for (int i = 1; i < ByteRange; i++)
            {
                offsetArr[i] = offsetArr[i - 1] + countArr[i - 1];
            }

            for (int i = 0; i < length; i++)
            {
                long l = BitConverter.DoubleToInt64Bits(source[i]);
                byte index = (byte)((LongToULong(l) >> byteOffset) & 0xFF);
                int offsetIndex = offsetArr[index];
                offsetArr[index] += 1;
                dest[offsetIndex] = source[i];
            }
        }
    }
}