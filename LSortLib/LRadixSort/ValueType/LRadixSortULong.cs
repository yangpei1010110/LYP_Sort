﻿using System;

namespace LYP_Utils.LSortLib.LRadixSort.ValueType
{
    public class LRadixSortULong : LRadixSort<ulong>
    {
        public new static LRadixSortULong Shared = new LRadixSortULong();
        private           ulong[]         _buffer;

        public LRadixSortULong(int initBufferSize = 0) =>
            _buffer = new ulong[Clamp(initBufferSize, 0, int.MaxValue)];

        public override void Sort(ulong[] source)
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

        private void RadixSortSequential(byte byteIndex, ulong[] source, ulong[] dest, int length)
        {
            Array.Clear(countArr, 0, countArr.Length);
            int byteOffset = byteIndex * 8;

            for (int i = 0; i < length; i++)
            {
                byte index = (byte)((source[i] >> byteOffset) & 0xFF);
                countArr[index] += 1;
            }


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