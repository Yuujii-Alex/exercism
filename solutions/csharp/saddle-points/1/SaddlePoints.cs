public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int val = matrix[i, j];
                bool isSaddle = true;

                // Check row max
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[i, c] > val)
                    {
                        isSaddle = false;
                        break;
                    }
                }

                if (!isSaddle) continue;

                // Check col min
                for (int r = 0; r < rows; r++)
                {
                    if (matrix[r, j] < val)
                    {
                        isSaddle = false;
                        break;
                    }
                }

                if (isSaddle)
                {
                    yield return (i + 1, j + 1);
                }
            }
        }
    }
}
