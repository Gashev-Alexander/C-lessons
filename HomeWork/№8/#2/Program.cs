using System;
using static System.Console;
using static System.Convert;
Clear();

Write("Введите количество строк: ");
int x = ToInt32(ReadLine());
Write("Введите количество столбцов: ");
int y = ToInt32(ReadLine());

int[,] array = new int[x, y];
Random Array = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Array.Next(10);
    }
}
WriteLine();
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Write(array[i, j] + " ");
    }
    WriteLine();
}


int SumMas(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int minSum = 0;
int sumLine = SumMas(array, 0);
for (int i = 1; i < x; i++)
{
    int tempSum = SumMas(array, i);
    if (sumLine > tempSum)
    {
        sumLine = tempSum;
        minSum = i;
    }
}

Console.WriteLine($"\nСтрокa с наименьшей суммой элементов №{minSum + 1}.");