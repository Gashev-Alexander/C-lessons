Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
int count = 0;
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,999);
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
for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;
Console.WriteLine($"\n{count} чисел из {numbers.Length} чётные.");