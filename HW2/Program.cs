// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindDigit(int[,] array, int digit)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (digit == array[i, j])
            {
                Console.WriteLine($"Ваше число находится в массиве на месте array[{i},{j}]");
                return;
            }
            else if (i == (array.GetLength(0)-1) & j == (array.GetLength(1)-1)) Console.WriteLine("Такого числа нет в массиве");
        }
    }
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.Write("Введите число которое необходимо найти в массиве ");
int DigitForFinding = Convert.ToInt32(Console.ReadLine());
FindDigit(matrix, DigitForFinding);