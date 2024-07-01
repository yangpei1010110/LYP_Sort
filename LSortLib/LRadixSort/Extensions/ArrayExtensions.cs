using System;

namespace LYP_Utils.LSortLib.LRadixSort.Extensions
{
    /// <summary>
    ///     这个类提供了一些扩展方法，用于对数组进行基数排序。
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        ///     对数组进行基数排序，排序的关键字由 keySelector 函数提供。
        /// </summary>
        /// <param name="array">需要排序的数组</param>
        /// <param name="keySelector">用于选择排序关键字的函数</param>
        public static void RadixSortBy<T, TKey>(this T[] array, Func<T, TKey> keySelector)
        {
            LRadixSortFactory.CreateGeneric(keySelector, array.Length).Sort(array);
        }

        /// <summary>
        ///     对数组进行基数排序，排序的关键字是数组元素本身。
        /// </summary>
        /// <param name="array">需要排序的数组</param>
        public static void RadixSort<T>(this T[] array)
        {
            LRadixSortFactory.CreateNonGeneric<T>(array.Length).Sort(array);
        }

        /// <summary>
        ///     对数组进行基数排序，排序的关键字是数组元素本身，排序算法使用的是共享的基数排序实例。
        /// </summary>
        /// <param name="array">需要排序的数组</param>
        public static void RadixSortShared<T>(this T[] array)
        {
            LRadixSort<T>.Shared.Sort(array);
        }
    }
}