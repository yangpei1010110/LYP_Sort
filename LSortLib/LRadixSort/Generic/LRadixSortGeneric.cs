using System;

namespace LYP_Sort.LSortLib.LRadixSort.Generic
{
    /// <summary>
    ///     基数排序泛型类
    /// </summary>
    public class LRadixSortGeneric<TValue, TKey>
    {
        /// <summary>
        ///     byte类型的范围
        /// </summary>
        public const int ByteRange = 256;

        protected LRadixSortGeneric()
        {
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
        public static LRadixSortGeneric<TValue, TKey>? Create(Func<TValue, TKey> keySelector, int initBufferSize = 0)
        {
            if (keySelector == null)
            {
                throw new ArgumentNullException(nameof(keySelector));
            }

            if (keySelector is Func<TValue, byte> byteSelector)
            {
                return new LRadixSortGenericByte<TValue>(byteSelector, initBufferSize)
                    as LRadixSortGeneric<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, sbyte> sbyteSelector)
            {
                return new LRadixSortGenericSByte<TValue>(sbyteSelector, initBufferSize)
                    as LRadixSortGeneric<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, short> shortSelector)
            {
                return new LRadixSortGenericShort<TValue>(shortSelector, initBufferSize)
                    as LRadixSortGeneric<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, ushort> ushortSelector)
            {
                return new LRadixSortGenericUShort<TValue>(ushortSelector, initBufferSize)
                    as LRadixSortGeneric<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, int> intSelector)
            {
                return new LRadixSortGenericInt<TValue>(intSelector, initBufferSize)
                    as LRadixSortGeneric<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, uint> uintSelector)
            {
                return new LRadixSortGenericUInt<TValue>(uintSelector, initBufferSize)
                    as LRadixSortGeneric<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, long> longSelector)
            {
                return new LRadixSortGenericLong<TValue>(longSelector, initBufferSize)
                    as LRadixSortGeneric<TValue, TKey>;
            }
            else if (keySelector is Func<TValue, ulong> ulongSelector)
            {
                return new LRadixSortGenericULong<TValue>(ulongSelector, initBufferSize)
                    as LRadixSortGeneric<TValue, TKey>;
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