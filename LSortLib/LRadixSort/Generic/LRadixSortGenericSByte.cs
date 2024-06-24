﻿using System;

namespace LYP_Sort.LSortLib.LRadixSort.Generic
{
    public class LRadixSortGenericSByte<TValue> : LRadixSortGeneric<TValue, sbyte>
    {
        private TValue[]            _buffer;
        private Func<TValue, sbyte> _keySelector;

        public LRadixSortGenericSByte(Func<TValue, sbyte> keySelector, int initBufferSize = 0)
        {
            _keySelector = keySelector;
            _buffer = new TValue[Math.Clamp(initBufferSize, 0, int.MaxValue)];
        }

        public static byte SByteToByte(sbyte value) => (byte)(value + sbyte.MaxValue + 1);

        public override void Sort(TValue[] source)
        {
            if (_buffer.Length < source.Length)
            {
                Array.Resize(ref _buffer, source.Length);
            }

            Array.Copy(source, _buffer, source.Length);
            int length = source.Length;

            RadixSortSequential(_buffer, source, length);
        }

        private void RadixSortSequential(TValue[] source, TValue[] dest, int length)
        {
            Span<int> countArr = stackalloc int[ByteRange];
            countArr.Clear();

            for (int i = 0; i < length; i++)
            {
                byte index = SByteToByte(_keySelector(source[i]));
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
                byte index = SByteToByte(_keySelector(source[i]));
                int offsetIndex = offsetArr[index];
                offsetArr[index] += 1;
                dest[offsetIndex] = source[i];
            }
        }
    }
}