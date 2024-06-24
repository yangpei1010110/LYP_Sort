using System;

namespace MyUtils.LSortLib.LRadixSort.ValueType
{
    public class LRadixSortFloat : LRadixSort<float>
    {
        public new static LRadixSortInt Shared = new LRadixSortInt();
        private           float[]       _buffer;

        public LRadixSortFloat(int initBufferSize = 0) => _buffer = new float[Clamp(initBufferSize, 0, int.MaxValue)];

        public override void Sort(float[] source)
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

        private void RadixSortSequential(byte byteIndex, float[] source, float[] dest, int length)
        {
            Array.Clear(countArr, 0, countArr.Length);
            int byteOffset = byteIndex * 8;

            for (int i = 0; i < length; i++)
            {
                int intVal = BitConverter.ToInt32(BitConverter.GetBytes(source[i]), 0);
                byte index = (byte)((IntToUInt(intVal) >> byteOffset) & 0xFF);
                countArr[index] += 1;
            }


            offsetArr[0] = 0;
            for (int i = 1; i < ByteRange; i++)
            {
                offsetArr[i] = offsetArr[i - 1] + countArr[i - 1];
            }

            for (int i = 0; i < length; i++)
            {
                int intVal = BitConverter.ToInt32(BitConverter.GetBytes(source[i]), 0);
                byte index = (byte)((IntToUInt(intVal) >> byteOffset) & 0xFF);
                int offsetIndex = offsetArr[index];
                offsetArr[index] += 1;
                dest[offsetIndex] = source[i];
            }
        }
    }
}