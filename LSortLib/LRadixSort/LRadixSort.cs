using System;

namespace LSortLib.LRadixSort
{
    /// <summary>
    ///     基数排序泛型类
    /// </summary>
    public class LRadixSort<TValue>
    {
        /// <summary>
        ///     byte类型的范围
        /// </summary>
        public const int ByteRange = 256;
        protected int[] countArr  = new int[ByteRange];
        protected int[] offsetArr = new int[ByteRange];

        protected LRadixSort()
        {
        }

        public static byte   SByteToByte(sbyte   value) => (byte)(value + sbyte.MaxValue + 1);
        public static ushort ShortToUShort(short value) => (ushort)(value + short.MaxValue + 1);
        public static uint   IntToUInt(int       value) => (uint)(value + int.MaxValue + 1);
        public static ulong  LongToULong(long    value) => (ulong)(value + long.MaxValue + 1);

        public static int Clamp(int value, int min, int max) => value < min ? min : value > max ? max : value;

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