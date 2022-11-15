namespace Helpers;

public static class MatrixHelper
{
  public static int[,] CreateMatrix(int[] list)
  {
    if (list.Length == 0) throw new ArgumentNullException("Input shouldn't not be empty array");

    var size = MatrixSize(list);
    var matrix = new int[size, size];
    var listCounter = 0;
 
    for (var r = 0; r < size; r++)
    {
      for (var c = 0;  c < size; c++)
      {
        matrix[r, c] = list[listCounter++];
      }
    }

    return matrix;
  }

  public static int MatrixSize(int[] list)
  {
    var size = Math.Sqrt(list.Length);
    if (size % 1 != 0) throw new ArgumentException("Number of elements must be a perfect square");
    return (int)size;
  }
}

