int[,] matrix = CreateMatrix(4, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
SortedMatrix(matrix);
PrintMatrix(matrix);





void SortedMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int k = 0;
        while (k < matrix.GetLength(1))
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int element = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = element;
                }

            }
            k++;
        }

    }
}





int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }

    return matrix;
}


void PrintMatrix(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}