Console.Clear();
Console.Write("Введите размер массива: ");
int SizeMas = int.Parse(Console.ReadLine());
int[] myArray = new int[SizeMas];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите массив с индексом {i} : ");
    myArray[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"{myArray[i]} ");
}

void TopArray(int[] coll)
{
    int count = coll.Length;
    int i = 0;
    Console.Write(" => ");
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

// Сортировка массива
{
Array.Sort(myArray);
for (int i = 0; i < myArray.Length; i++)     
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
}