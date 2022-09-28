Console.Clear();
Console.Write("Введите размер массива: ");
int SizeMas = int.Parse(Console.ReadLine());
int[] myArray = new int[SizeMas];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент массива с индексом {i} : ");
    myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nВывод массива:");

void TopArray(int[] coll)
{
    int count = coll.Length;
    int i = 0;
    Console.Write("[");
    while(i < count)
{
        Console.Write(coll[i]);
        i++;
        if (i < count)
    {
        Console.Write(", ");
    }
}
  Console.Write("]");
}
TopArray(myArray);

int[] nums = myArray;
 
int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}

//Сортировка массива
Console.WriteLine("\n\nВывод отсортированного массива:");
{
    void SortArray(int[] up)
    {
        int count = up.Length;
        int i = 0;
        Console.Write("[");
        while(i < count)
    {
        Console.Write(up[i]);
        i++;
        if (i < count)
    {
        Console.Write(", ");
    }
    }
        Console.Write("]");
    }
SortArray(myArray);
}

//Нажодение максимального элемента массива
{
int [] ar = myArray;
int maxValue = ar.OrderByDescending(x => x).First();
Console.WriteLine("\n\nМаксимальный элемент массива:");
Console.WriteLine($"[{maxValue}]");
}

//Сумма всех элементов массива
{
int[] mas = myArray;
    int rez = mas.Sum();
Console.WriteLine("\nСумма всех элементов массива:");
Console.WriteLine($"[{rez}]");
}