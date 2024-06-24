using System;

namespace LSortLib.LRadixSort.ValueType
{
    public class LRadixSortInt : LRadixSort<int>
    {
        private int[] _buffer;

        public LRadixSortInt(int initBufferSize = 0) => _buffer = new int[Clamp(initBufferSize, 0, int.MaxValue)];

        public override void Sort(int[] source)
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
        }

        private void RadixSortSequential(byte byteIndex, int[] source, int[] dest, int length)
        {
            Array.Clear(countArr, 0, countArr.Length);
            int byteOffset = byteIndex * 8;

            for (int i = 0; i < length; i++)
            {
                byte index = (byte)((IntToUInt(source[i]) >> byteOffset) & 0xFF);
                countArr[index] += 1;
            }


            offsetArr[0] = 0;
            for (int i = 1; i < ByteRange; i++)
            {
                offsetArr[i] = offsetArr[i - 1] + countArr[i - 1];
            }

            for (int i = 0; i < length; i++)
            {
                byte index = (byte)((IntToUInt(source[i]) >> byteOffset) & 0xFF);
                int offsetIndex = offsetArr[index];
                offsetArr[index] += 1;
                dest[offsetIndex] = source[i];
            }
        }
    }
}