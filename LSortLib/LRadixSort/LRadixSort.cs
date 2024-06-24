using System;

namespace LYP_Sort.LSortLib.LRadixSort
{
    public class LRadixSort<T>
    {
        private T[]          _buffer;
        private Func<T, int> _keySelector;

        public LRadixSort(Func<T, int> keySelector, int initBufferSize = 0)
        {
            _keySelector = keySelector;
            if (initBufferSize <= 0)
            {
                _buffer = Array.Empty<T>();
            }
            else
            {
                _buffer = new T[initBufferSize];
            }
        }

        public void Sort(T[] source)
        {
            if (source == null || source.Length <= 1)
            {
                return;
            }

            // if (source.Length <= _stackAllocLimit)
            // {
            //     SortWithSpan(source);
            // }
            // else
            {
                SortWithArrayBuffer(source);
            }
        }

        public void RadixSortSequential(byte byteIndex, T[] source)
        {
            if (_buffer.Length < source.Length)
            {
                Array.Resize(ref _buffer, source.Length);
            }

            Array.Copy(source, _buffer, source.Length);

            Span<int> countArr = stackalloc int[256];
            countArr.Clear();
            int byteOffset = byteIndex * 8;

            for (int i = 0; i < source.Length; i++)
            {
                byte index = (byte)((_keySelector(_buffer[i]) >> byteOffset) & 0xFF);
                countArr[index] += 1;
            }

            Span<int> offsetArr = stackalloc int[256];
            offsetArr[0] = 0;
            for (int i = 1; i < 256; i++)
            {
                offsetArr[i] = offsetArr[i - 1] + countArr[i - 1];
            }

            for (int i = 0; i < source.Length; i++)
            {
                byte index = (byte)((_keySelector(_buffer[i]) >> byteOffset) & 0xFF);
                int offsetIndex = offsetArr[index];
                offsetArr[index] += 1;
                source[offsetIndex] = _buffer[i];
            }
        }

        // private void SortWithSpan(T[] source)
        // {
        //     T[] sourceCopy = new T[source.Length];
        //     Array.Copy(source, sourceCopy, sourceCopy.Length);
        //
        //     Span<int> countArr = stackalloc int[256];
        //     countArr.Clear();
        //
        //     for (int i = 0; i < sourceCopy.Length; i++)
        //     {
        //         byte index = _keySelector(sourceCopy[i]);
        //         countArr[index] += 1;
        //     }
        //
        //     Span<int> offsetArr = stackalloc int[256];
        //     offsetArr[0] = 0;
        //     for (int i = 1; i < 256; i++)
        //     {
        //         offsetArr[i] = offsetArr[i - 1] + countArr[i - 1];
        //     }
        //
        //
        //     for (int i = 0; i < sourceCopy.Length; i++)
        //     {
        //         byte index = _keySelector(sourceCopy[i]);
        //         int offsetIndex = offsetArr[index];
        //         offsetArr[index] += 1;
        //         source[offsetIndex] = sourceCopy[i];
        //     }
        // }

        private void SortWithArrayBuffer(T[] source)
        {
            RadixSortSequential(0, source);
            RadixSortSequential(1, source);
            RadixSortSequential(2, source);
            RadixSortSequential(3, source);
            RadixSortSequential(4, source);
            RadixSortSequential(5, source);
            RadixSortSequential(6, source);
            RadixSortSequential(7, source);

            // if (_buffer.Length < source.Length)
            // {
            //     Array.Resize(ref _buffer, source.Length);
            // }
            //
            // Array.Copy(source, _buffer, source.Length);
            //
            // Span<int> countArr = stackalloc int[256];
            // countArr.Clear();
            //
            // for (int i = 0; i < source.Length; i++)
            // {
            //     byte index = _keySelector(_buffer[i]);
            //     countArr[index] += 1;
            // }
            //
            // Span<int> offsetArr = stackalloc int[256];
            // offsetArr[0] = 0;
            // for (int i = 1; i < 256; i++)
            // {
            //     offsetArr[i] = offsetArr[i - 1] + countArr[i - 1];
            // }
            //
            // for (int i = 0; i < source.Length; i++)
            // {
            //     byte index = _keySelector(_buffer[i]);
            //     int offsetIndex = offsetArr[index];
            //     offsetArr[index] += 1;
            //     source[offsetIndex] = _buffer[i];
            // }
        }
    }
}