Console.Clear();
Console.Write("Введите число строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[x, y];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(99));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}

Console.Write("Введите номер строки для поиска: ");
int xs = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца для поиска: ");
int ys = Convert.ToInt32(Console.ReadLine());

if (xs-1 >= x || ys-1 >= y)
{
    Console.WriteLine($"В {xs} строке иs {ys} столбце чисел нет.");
}

else
{
    object? search = array.GetValue(xs-1, ys-1);
    Console.WriteLine($"В {xs} строке и в {ys} столбце содежится число => {search}");
}