Console.Clear();
Console.Write("Введите размер массива: ");
int SizeMas = int.Parse(Console.ReadLine());
int[] array = GetBinaryArray(SizeMas);
Console.WriteLine($"[{String.Join(", ", array)}]");
int[] GetBinaryArray(int size)
    {
        int[] result = new int  [size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(-9,9);
        }
    return result;
    }

// сумма отрицательных и положительных чисел
int plus = 0;
for (int i = 0; i < array.Length; i++)
if (array[i] > 0)
plus += array[i]; 
Console.Write("Сумма положительных чисел: ");
Console.WriteLine(plus);

int minus = 0;
for (int i = 0; i < array.Length; i++)
if (array[i] < 0)
minus += array[i]; 
Console.Write("Сумма отрицательных чисел: ");
Console.WriteLine(minus);


// противоположность массива
for (int i = array.Length - 1; i > array.Length * (-1); i--)
            array[i] = -1*array[i];
            
        Console.Write("Изменённый массив: ");
         for (int i = 0; i < array.Length; i++)
            Console.Write((i != array.Length - 1) ? $"{array[i]}; " : $"{array[i]}\n");
            
        Console.ReadKey();