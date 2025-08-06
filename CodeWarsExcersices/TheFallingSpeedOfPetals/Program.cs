/// <summary>
/// Provides utility methods for sakura petal behavior.
/// </summary>
public static class Kata
{
    /// <summary>
    /// Calculates the time it takes for a sakura petal to fall from a branch, given its falling speed.
    /// </summary>
    /// <param name="v">The speed of the petal in centimeters per second (cm/s).</param>
    /// <returns>
    /// The time in seconds it takes for the petal to reach the ground.
    /// Returns 0 if the speed is zero or negative.
    /// </returns>
    public static double SakuraFall(double v)
    {
        if (v > 0)
        {
            double height = 5 * 80;
            double time = 0;
            time = height / v;
            return time;
        }
        else
        {
            return 0;
        }
    }
}
