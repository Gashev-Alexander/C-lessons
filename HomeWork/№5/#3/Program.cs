Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(999);
    }
}
Console.Clear();
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
TopArray(numbers);

int maxN = numbers[0];
int minN = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (maxN < numbers[i])
    {
        maxN = numbers[i];
    }
        if (minN > numbers[i])
    {
        minN = numbers[i];
    }
}

int raznica = (maxN - minN);
Console.WriteLine($"\nМинимальный элемент массива        => {minN} \nМаксимальный элемент массива       => {maxN}");
Console.WriteLine($"Разница между Min и Max элементами => {raznica}");