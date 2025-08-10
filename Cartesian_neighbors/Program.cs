using System;
using System.Collections.Generic;

/// <summary>
/// Returns a list of all eight neighboring points of the given (x, y) coordinate
/// on a Cartesian grid with a step size of 1.
/// Neighboring points include all adjacent points horizontally, vertically,
/// and diagonally.
/// </summary>
/// <param name="x">The x-coordinate of the point.</param>
/// <param name="y">The y-coordinate of the point.</param>
/// <returns>
/// A list of integer arrays, each containing two elements representing the
/// x and y coordinates of a neighboring point.
/// </returns>

public class Kata
{
    public static IEnumerable<int[]> cartesianNeighbor(int x, int y)
    {
        int x_value = 0;
        int y_value = 0;
        List<int[]> lista = new List<int[]>();
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                if (i == 0 && j == 0) continue;
                lista.Add(new int[] { x + i, y + j });
            }
        }
        return lista;
    }
}
