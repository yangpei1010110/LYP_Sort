namespace LSortLib.LRadixSort.Extensions
{
    public static class ArrayExtensions
    {
        public static void RadixSort<T>(this T[] array)
        {
            LRadixSortFactory.CreateNonGeneric<T>().Sort(array);
        }
    }
}