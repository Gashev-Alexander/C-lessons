Console.Clear();
Console.Write($"Введи размер массива: ");
int numbers = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numbers, int min, int max)
{
int[] randomNumbers = new int[numbers];
int sum = 0;

for (int i = 0; i <randomNumbers.Length; i++ )
    {
    randomNumbers[i] = new Random().Next(9);

Console.Clear();
void RandomNumbers(int[] coll)
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
RandomNumbers(randomNumbers);

      if (i % 2 == 1)
      {
        sum = sum + randomNumbers[i];
      }
    }
  return sum;
}
int randomNumbers =  RandomNumbers(numbers, 1, 10);

Console.WriteLine($"\nСуммма элементов на нечетных индексах => {randomNumbers}");