using System;

namespace LYP_Sort.LSortLib.LRadixSort.ValueType
{
    public class LRadixSortUShort : LRadixSort<ushort>
    {
        private ushort[] _buffer;

        public LRadixSortUShort(int initBufferSize = 0) =>
            _buffer = new ushort[Clamp(initBufferSize, 0, int.MaxValue)];

        public override void Sort(ushort[] source)
        {
            if (_buffer.Length < source.Length)
            {
                Array.Resize(ref _buffer, source.Length);
            }

            int length = source.Length;
            RadixSortSequential(0, source, _buffer, length);
            RadixSortSequential(1, _buffer, source, length);
        }

        private void RadixSortSequential(byte byteIndex, ushort[] source, ushort[] dest, int length)
        {
            Span<int> countArr = stackalloc int[ByteRange];
            countArr.Clear();
            int byteOffset = byteIndex * 8;

            for (int i = 0; i < length; i++)
            {
                byte index = (byte)((source[i] >> byteOffset) & 0xFF);
                countArr[index] += 1;
            }

            Span<int> offsetArr = stackalloc int[ByteRange];
            offsetArr[0] = 0;
            for (int i = 1; i < ByteRange; i++)
            {
                offsetArr[i] = offsetArr[i - 1] + countArr[i - 1];
            }

            for (int i = 0; i < length; i++)
            {
                byte index = (byte)((source[i] >> byteOffset) & 0xFF);
                int offsetIndex = offsetArr[index];
                offsetArr[index] += 1;
                dest[offsetIndex] = source[i];
            }
        }
    }
}