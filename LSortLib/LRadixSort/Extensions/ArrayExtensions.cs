namespace LSortLib.LRadixSort.Extensions
{
    public static class ArrayExtensions
    {
        public static void RadixSort<T>(this T[] array)
        {
            LRadixSortFactory.CreateNonGeneric<T>().Sort(array);
        }

        public static void RadixSortShared<T>(this T[] array)
        {
            LRadixSort<T>.Shared.Sort(array);
        }
    }
}