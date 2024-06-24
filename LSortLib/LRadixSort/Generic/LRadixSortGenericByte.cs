using System;

namespace MyUtils.LSortLib.LRadixSort.Generic
{
    public class LRadixSortGenericByte<TValue> : LRadixSort<TValue>
    {
        private TValue[]           _buffer;
        private Func<TValue, byte> _keySelector;

        public LRadixSortGenericByte(Func<TValue, byte> keySelector, int initBufferSize = 0)
        {
            _keySelector = keySelector;
            _buffer = new TValue[Clamp(initBufferSize, 0, int.MaxValue)];
        }

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
            Array.Clear(countArr, 0, countArr.Length);

            for (int i = 0; i < length; i++)
            {
                byte index = _keySelector(source[i]);
                countArr[index] += 1;
            }

            offsetArr[0] = 0;
            for (int i = 1; i < ByteRange; i++)
            {
                offsetArr[i] = offsetArr[i - 1] + countArr[i - 1];
            }

            for (int i = 0; i < length; i++)
            {
                byte index = _keySelector(source[i]);
                int offsetIndex = offsetArr[index];
                offsetArr[index] += 1;
                dest[offsetIndex] = source[i];
            }
        }
    }
}