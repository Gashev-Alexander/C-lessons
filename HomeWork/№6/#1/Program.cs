Console.Clear();
Console.Write("Введите размер массива: ");
int SizeM = int.Parse(Console.ReadLine());
int[] array = GetBinaryArray(SizeM);
Console.WriteLine($"[{String.Join(",", array)}]");
        
int[] GetBinaryArray(int size)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-99,99);
    }
return result;
}

int Comparison(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count += 1; 
  }
  return count;
}

Console.WriteLine($"Чисел больше 0 => {Comparison(array)} ");