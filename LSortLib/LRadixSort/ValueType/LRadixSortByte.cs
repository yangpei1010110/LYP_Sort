using System;

namespace LYP_Sort.LSortLib.LRadixSort.ValueType
{
    public class LRadixSortByte : LRadixSort<byte>
    {
        private byte[] _buffer;

        public LRadixSortByte(int initBufferSize = 0) =>
            _buffer = new byte[Clamp(initBufferSize, 0, int.MaxValue)];

        public override void Sort(byte[] source)
        {
            if (_buffer.Length < source.Length)
            {
                Array.Resize(ref _buffer, source.Length);
            }

            Array.Copy(source, _buffer, source.Length);
            int length = source.Length;
            RadixSortSequential(_buffer, source, length);
        }

        private void RadixSortSequential(byte[] source, byte[] dest, int length)
        {
            Array.Clear(countArr, 0, countArr.Length);

            for (int i = 0; i < length; i++)
            {
                byte index = source[i];
                countArr[index] += 1;
            }

            offsetArr[0] = 0;
            for (int i = 1; i < ByteRange; i++)
            {
                offsetArr[i] = offsetArr[i - 1] + countArr[i - 1];
            }

            for (int i = 0; i < length; i++)
            {
                byte index = source[i];
                int offsetIndex = offsetArr[index];
                offsetArr[index] += 1;
                dest[offsetIndex] = source[i];
            }
        }
    }
}