Console.Clear();
Console.Write("Введите размер массива: ");
int SizeMas = Convert.ToInt32(Console.ReadLine());
int[] arr = GetBinaryArray(SizeMas);
Console.WriteLine($"Оригинальный массив: \n[{String.Join(",", arr)}]");

int[] GetBinaryArray(int size)
{
    Console.Clear();
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(99);
    }
    return result;
}


// копирование массива
int[] copy = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    copy[i] = arr[i];
}

Console.WriteLine($"\nКопия массива: \n[{String.Join(",", copy)}]");