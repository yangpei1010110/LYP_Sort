using System;

namespace LYP_Sort.LSortLib.LRadixSort.Generic
{
    public class LRadixSortGenericUShort<TValue> : LRadixSort<TValue, ushort>
    {
        private TValue[]             _buffer;
        private Func<TValue, ushort> _keySelector;

        public LRadixSortGenericUShort(Func<TValue, ushort> keySelector, int initBufferSize = 0)
        {
            _keySelector = keySelector;
            _buffer = new TValue[Math.Clamp(initBufferSize, 0, int.MaxValue)];
        }

        public override void Sort(TValue[] source)
        {
            if (_buffer.Length < source.Length)
            {
                Array.Resize(ref _buffer, source.Length);
            }

            int length = source.Length;

            RadixSortSequential(0, source, _buffer, length);
            RadixSortSequential(1, _buffer, source, length);
        }

        private void RadixSortSequential(byte byteIndex, TValue[] source, TValue[] dest, int length)
        {
            Span<int> countArr = stackalloc int[ByteRange];
            countArr.Clear();
            int byteOffset = byteIndex * 8;

            for (int i = 0; i < length; i++)
            {
                byte index = (byte)((_keySelector(source[i]) >> byteOffset) & 0xFF);
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
                byte index = (byte)((_keySelector(source[i]) >> byteOffset) & 0xFF);
                int offsetIndex = offsetArr[index];
                offsetArr[index] += 1;
                dest[offsetIndex] = source[i];
            }
        }
    }
}