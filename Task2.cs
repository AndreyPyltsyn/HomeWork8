int[,] matrix = CreateMatrix(4, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = ArraySumRows(matrix);
MinSumRow(array);





void MinSumRow(int[] array)
{
    int min = array[0];
    int k = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            k = i + 1;
        }
    }
    Console.WriteLine("Номер строки с наименьшей суммой элементов:" + k);
}






int[] ArraySumRows(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int min = int.MinValue;
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[k] = sum;
        k++;
    }
    return array;

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