int[,] matrix1 = CreateMatrix(3, 3, 0, 10);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrix(3, 3, 0, 10);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] matrix3 = ResultProdMatrix(matrix1, matrix2);
PrintMatrix(matrix3);

int[,] ResultProdMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix;
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