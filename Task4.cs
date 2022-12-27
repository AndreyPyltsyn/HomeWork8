int[] array = CreateArray(10, 100);
Console.WriteLine();
int[,,] matrix1 = CreateMatrix(3, 3, 3, array);
PrintMatrix(matrix1);
Console.WriteLine();


int[] CreateArray(int min, int max)
{
    int[] array = new int[90];
    array[0] = 10;
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = array[i - 1] + 1;
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}








int[,,] CreateMatrix(int m, int n, int b, int[] array)
{
    int[,,] matrix = new int[m, n, b];
    int c = array.Length - 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = array[c];
                c--;
            }

        }
    }

    return matrix;
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k]);
                Console.Write("(" + i);
                Console.Write($",{j},");
                Console.Write(k + ") ");
            }
            Console.WriteLine();
        }
    }
}