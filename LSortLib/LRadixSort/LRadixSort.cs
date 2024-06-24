using System;
using LYP_Sort.LSortLib.LRadixSort.Generic;
using LYP_Sort.LSortLib.LRadixSort.ValueType;

namespace LYP_Sort.LSortLib.LRadixSort
{
    /// <summary>
    ///     基数排序泛型类
    /// </summary>
    public class LRadixSort<TValue, TKey>
    {
        /// <summary>
        ///     byte类型的范围
        /// </summary>
        public const int ByteRange = 256;

        protected LRadixSort()
        {
        }

        public static byte   SByteToByte(sbyte   value) => (byte)(value + sbyte.MaxValue + 1);
        public static ushort ShortToUShort(short value) => (ushort)(value + short.MaxValue + 1);
        public static uint   IntToUInt(int       value) => (uint)(value + int.MaxValue + 1);
        public static ulong  LongToULong(long    value) => (ulong)(value + long.MaxValue + 1);

        public static LRadixSort<T, T>? CreateNonGeneric<T>(int initBufferSize = 0)
        {
            Type tType = typeof(T);

            if (tType == typeof(byte))
            {
                return new LRadixSortByte(initBufferSize) as LRadixSort<T, T>;
            }
            else if (tType == typeof(sbyte))
            {
                return new LRadixSortSByte(initBufferSize) as LRadixSort<T, T>;
            }
            else if (tType == typeof(ushort))
            {
                return new LRadixSortUShort(initBufferSize) as LRadixSort<T, T>;
            }
            else if (tType == typeof(short))
            {
                return new LRadixSortShort(initBufferSize) as LRadixSort<T, T>;
            }
            else if (tType == typeof(uint))
            {
                return new LRadixSortUInt(initBufferSize) as LRadixSort<T, T>;
            }
            else if (tType == typeof(int))
            {
                return new LRadixSortInt(initBufferSize) as LRadixSort<T, T>;
            }
            else if (tType == typeof(ulong))
            {
                return new LRadixSortULong(initBufferSize) as LRadixSort<T, T>;
            }
            else if (tType == typeof(long))
            {
                return new LRadixSortLong(initBufferSize) as LRadixSort<T, T>;
            }
            else
            {
                throw new NotSupportedException($"Not supported type: {tType}");
            }
        }

        /// <summary>
        ///     创建基数排序泛型类
        ///     通过传入一个函数作为键选择器，以及一个初始化缓冲区大小（默认为0），
        ///     来创建一个基数排序泛型类的实例。
        ///     键选择器的类型决定了返回的基数排序泛型类的类型。
        /// </summary>
        /// <param name="keySelector">键选择器函数，用于从TValue中选择一个键</param>
        /// <param name="initBufferSize">初始化缓冲区大小，默认为0</param>
        /// <returns>返回一个基数排序泛型类的实例</returns>
        public static LRadixSort<TValue, TKey>? CreateGeneric(Func<TValue, TKey> keySelector,
                                                              int                initBufferSize = 0)
        {
            if (keySelector == null)
            {
                throw new ArgumentNullException(nameof(keySelector));
            }

            if (keySelector is Func<TValue, byte> byteSelector)
            {
                return new LRadixSortGenericByte<TValue>(byteSelector, initBufferSize)
                    as LRadixSort<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, sbyte> sbyteSelector)
            {
                return new LRadixSortGenericSByte<TValue>(sbyteSelector, initBufferSize)
                    as LRadixSort<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, short> shortSelector)
            {
                return new LRadixSortGenericShort<TValue>(shortSelector, initBufferSize)
                    as LRadixSort<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, ushort> ushortSelector)
            {
                return new LRadixSortGenericUShort<TValue>(ushortSelector, initBufferSize)
                    as LRadixSort<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, int> intSelector)
            {
                return new LRadixSortGenericInt<TValue>(intSelector, initBufferSize)
                    as LRadixSort<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, uint> uintSelector)
            {
                return new LRadixSortGenericUInt<TValue>(uintSelector, initBufferSize)
                    as LRadixSort<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, long> longSelector)
            {
                return new LRadixSortGenericLong<TValue>(longSelector, initBufferSize)
                    as LRadixSort<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, ulong> ulongSelector)
            {
                return new LRadixSortGenericULong<TValue>(ulongSelector, initBufferSize)
                    as LRadixSort<TValue, TKey>;
            }
            else
            {
                throw new NotSupportedException($"Not supported key type: {typeof(TKey)}");
            }
        }

        /// <summary>
        ///     对源数组进行排序
        ///     这是一个虚方法，需要在派生类中实现具体的排序逻辑。
        /// </summary>
        /// <param name="source">需要排序的源数组</param>
        public virtual void Sort(TValue[] source)
        {
            throw new NotSupportedException();
        }
    }
}