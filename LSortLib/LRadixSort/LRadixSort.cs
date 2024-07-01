using System;
using LYP_Utils.LSortLib.LRadixSort.ValueType;

namespace LYP_Utils.LSortLib.LRadixSort
{
    /// <summary>
    ///     This class provides a generic implementation of Radix Sort.
    /// </summary>
    public class LRadixSort<TValue>
    {
        /// <summary>
        ///     Singleton instance of LRadixSort for the specific type TValue.
        ///     It returns the shared instance of the appropriate LRadixSort subclass based on the type of TValue.
        ///     If TValue is not a supported type, it throws a NotSupportedException.
        /// </summary>
        public static LRadixSort<TValue> Shared
        {
            get
            {
                Type valueType = typeof(TValue);
                if (valueType == typeof(sbyte))
                {
                    return LRadixSortSByte.Shared as LRadixSort<TValue>;
                }
                else if (valueType == typeof(byte))
                {
                    return LRadixSortByte.Shared as LRadixSort<TValue>;
                }
                else if (valueType == typeof(short))
                {
                    return LRadixSortShort.Shared as LRadixSort<TValue>;
                }
                else if (valueType == typeof(ushort))
                {
                    return LRadixSortUShort.Shared as LRadixSort<TValue>;
                }
                else if (valueType == typeof(int))
                {
                    return LRadixSortInt.Shared as LRadixSort<TValue>;
                }
                else if (valueType == typeof(uint))
                {
                    return LRadixSortUInt.Shared as LRadixSort<TValue>;
                }
                else if (valueType == typeof(long))
                {
                    return LRadixSortLong.Shared as LRadixSort<TValue>;
                }
                else if (valueType == typeof(ulong))
                {
                    return LRadixSortULong.Shared as LRadixSort<TValue>;
                }
                else
                {
                    throw new NotSupportedException();
                }
            }
        }

        /// <summary>
        ///     The range of byte type.
        /// </summary>
        protected const int ByteRange = 256;
        protected int[] countArr  = new int[ByteRange];
        protected int[] offsetArr = new int[ByteRange];

        /// <summary>
        ///     Protected constructor to prevent direct instantiation.
        /// </summary>
        protected LRadixSort()
        {
        }

        /// <summary>
        ///     These methods convert signed types to unsigned types by adding the maximum value of the signed type plus one.
        /// </summary>
        protected static byte SByteToByte(sbyte value) => (byte)(value + sbyte.MaxValue + 1);

        protected static ushort ShortToUShort(short value) => (ushort)(value + short.MaxValue + 1);
        protected static uint   IntToUInt(int       value) => (uint)(value + int.MaxValue + 1);
        protected static ulong  LongToULong(long    value) => (ulong)(value + long.MaxValue + 1);

        /// <summary>
        ///     This method clamps a value between a minimum and maximum value.
        /// </summary>
        protected static int Clamp(int value, int min, int max) => value < min ? min : value > max ? max : value;

        /// <summary>
        ///     This method sorts an array of type TValue.
        ///     It is a virtual method and needs to be implemented in the derived classes.
        ///     If called directly from the base class, it throws a NotSupportedException.
        /// </summary>
        /// <param name="source">The array to be sorted.</param>
        public virtual void Sort(TValue[] source)
        {
            throw new NotSupportedException();
        }
    }
}