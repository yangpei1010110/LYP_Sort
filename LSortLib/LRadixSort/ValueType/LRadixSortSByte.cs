using System;

namespace LSortLib.LRadixSort.ValueType
{
    public class LRadixSortSByte : LRadixSort<sbyte>
    {
        public new static LRadixSortSByte Shared = new LRadixSortSByte();
        private           sbyte[]         _buffer;

        public LRadixSortSByte(int initBufferSize = 0) =>
            _buffer = new sbyte[Clamp(initBufferSize, 0, int.MaxValue)];

        public override void Sort(sbyte[] source)
        {
            if (_buffer.Length < source.Length)
            {
                Array.Resize(ref _buffer, source.Length);
            }

            Array.Copy(source, _buffer, source.Length);
            int length = source.Length;
            RadixSortSequential(_buffer, source, length);
        }

        private void RadixSortSequential(sbyte[] source, sbyte[] dest, int length)
        {
            Array.Clear(countArr, 0, countArr.Length);

            for (int i = 0; i < length; i++)
            {
                byte index = SByteToByte(source[i]);
                countArr[index] += 1;
            }


            offsetArr[0] = 0;
            for (int i = 1; i < ByteRange; i++)
            {
                offsetArr[i] = offsetArr[i - 1] + countArr[i - 1];
            }

            for (int i = 0; i < length; i++)
            {
                byte index = SByteToByte(source[i]);
                int offsetIndex = offsetArr[index];
                offsetArr[index] += 1;
                dest[offsetIndex] = source[i];
            }
        }
    }
}