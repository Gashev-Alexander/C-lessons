﻿ Console.Clear();
        Console.Write("Введите размер массива: ");
        int SizeMas = int.Parse(Console.ReadLine());
        int[] array = GetBinaryArray(SizeMas);
        Console.WriteLine($"[{String.Join(",", array)}]");


int[] GetBinaryArray(int size)
{
    int[] result = new int  [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(99);
    }

    return result;
}