Console.Clear();
Console.Write("Введите размер массива: ");
int SizeMas = int.Parse(Console.ReadLine());
int[] array = GetBinaryArray(SizeMas);
Console.WriteLine($"[{String.Join(",", array)}]");        
int[] GetBinaryArray(int size)
{
    int[] result = new int  [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(9999);
    }
    return result;
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (FindElement(array, n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

bool FindElement(int[] array, int el)
{
    foreach (var item in array)
    {
        if (el == item) return true;
    }
    return false;
}