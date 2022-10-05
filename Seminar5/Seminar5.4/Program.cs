Console.Clear();
Console.Write("Введите размер массива: ");
int SizeMas = Convert.ToInt32(Console.ReadLine());
int[] array = GetBinaryArray(SizeMas);
Console.WriteLine($"[{String.Join(", ", array)}]");
int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(99);
    }
    return result;
}

Console.WriteLine("Умножение крайних элементов по порядку: ");
Console.WriteLine(String.Join(" ", ResultArray(array)));

int[] ResultArray(int[] array)
{

    int size = (array.Length + 1) / 2;
    //    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {

        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];
    return result;
}
