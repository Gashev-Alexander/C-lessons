using System;
using static System.Console;
using static System.Convert;
Clear();
ForegroundColor = ConsoleColor.Red;
WriteLine("СОРТИРОВКА ДВУМЕРНОГО МАССИВА");
ResetColor();

Write("Введите количество строк: ");
int x = ToInt32(ReadLine());
Write("Введите количество столбцов: ");
int y = ToInt32(ReadLine());

Clear();
WriteLine("\nОсновной массив:");

int[,] DuoMas = new int[x, y];
Random DouMas = new Random();
for (int i = 0; i < DuoMas.GetLength(0); i++)
{
    for (int j = 0; j < DuoMas.GetLength(1); j++)
    {
        DuoMas[i, j] = DouMas.Next(10);
    }
}
WriteLine();
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Write(DuoMas[i, j] + " ");
    }
    WriteLine();
}


WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(DuoMas);
WriteArray(DuoMas);

void OrderArrayLines(int[,] DouMas)
{
    for (int i = 0; i < DouMas.GetLength(0); i++)
    {
        for (int j = 0; j < DouMas.GetLength(1); j++)
        {
            for (int k = 0; k < DouMas.GetLength(1) - 1; k++)
            {
                if (DouMas[i, k] < DouMas[i, k + 1])
                {
                    int temp = DouMas[i, k + 1];
                    DouMas[i, k + 1] = DouMas[i, k];
                    DouMas[i, k] = temp;
                }
            }
        }
    }
}
void WriteArray(int[,] DouMas)
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Write(DouMas[i, j] + " ");
        }
        WriteLine();
    }
}
WriteLine();