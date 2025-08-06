/// <summary>
/// Provides utility methods for working with number sequences.
/// </summary>
public class Kata
{
    /// <summary>
    /// Finds the first non-consecutive number in a sorted array of unique integers.
    /// </summary>
    /// <param name="arr">An array of unique integers in ascending order.</param>
    /// <returns>
    /// The first integer that is not exactly 1 greater than its predecessor.
    /// Returns null if the array is null, empty, or all elements are consecutive.
    /// </returns>
    public static object FirstNonConsecutive(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            return null;
        }
        else
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] != 1)
                {
                    return arr[i];
                }
            }
            return null;
        }
    }
}
