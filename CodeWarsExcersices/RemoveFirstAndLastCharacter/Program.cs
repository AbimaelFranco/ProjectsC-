using System;

/// <summary>
/// Contains methods for string manipulation.
/// </summary>
public class Kata
{
    /// <summary>
    /// Removes the first and last characters from the given string.
    /// </summary>
    /// <param name="s">The original string with at least 2 characters.</param>
    /// <returns>
    /// A new string with the first and last characters removed.
    /// Returns an empty string if the input string has exactly 2 or fewer characters.
    /// </returns>
    public static string Remove_char(string s)
    {
        if (s.Length <= 2)
            return "";
        return s.Substring(1, s.Length - 2);
    }
}
