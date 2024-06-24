using System;

namespace LYP_Sort.LSortLib.LRadixSort.ValueType
{
    public class LRadixSortShort : LRadixSort<short>
    {
        private short[] _buffer;

        public LRadixSortShort(int initBufferSize = 0) =>
            _buffer = new short[Clamp(initBufferSize, 0, int.MaxValue)];

        public override void Sort(short[] source)
        {
            if (_buffer.Length < source.Length)
            {
                Array.Resize(ref _buffer, source.Length);
            }

            int length = source.Length;
            RadixSortSequential(0, source, _buffer, length);
            RadixSortSequential(1, _buffer, source, length);
        }

        private void RadixSortSequential(byte byteIndex, short[] source, short[] dest, int length)
        {
            Array.Clear(countArr, 0, countArr.Length);
            int byteOffset = byteIndex * 8;

            for (int i = 0; i < length; i++)
            {
                byte index = (byte)((ShortToUShort(source[i]) >> byteOffset) & 0xFF);
                countArr[index] += 1;
            }


            offsetArr[0] = 0;
            for (int i = 1; i < ByteRange; i++)
            {
                offsetArr[i] = offsetArr[i - 1] + countArr[i - 1];
            }

            for (int i = 0; i < length; i++)
            {
                byte index = (byte)((ShortToUShort(source[i]) >> byteOffset) & 0xFF);
                int offsetIndex = offsetArr[index];
                offsetArr[index] += 1;
                dest[offsetIndex] = source[i];
            }
        }
    }
}