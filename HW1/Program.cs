// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0, 5    7 -2 -0,2
// 1 -3,3  8 -9, 9
// 8  7,8 -7, 1  9

Double[,] matrix = new Double[3, 4];

void FillDoubleArray(Double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * new Random().Next(-9,10);
        }
    }
}

void PrintDoubleArray(Double[,] array)
{
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            number = Convert.ToInt32(array[i, j]*10);
            if (number%10 == 0) Console.Write($"{array[i, j]:N0} ");
            else Console.Write($"{array[i, j]:N1} ");
        }
        Console.WriteLine();
    }
}

FillDoubleArray(matrix);
PrintDoubleArray(matrix);