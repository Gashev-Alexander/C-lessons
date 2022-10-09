// Console.Clear();
Console.Write("Введите число строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число колон: ");
int y = Convert.ToInt32(Console.ReadLine());

double[,] Meow = new double[x, y];

Random array = new Random();
for (int i = 0; i < Meow.GetLength(0); i++)
{
    for (int j = 0; j < Meow.GetLength(0); j++)
    {
        Meow[i, j] = array.Next(-10, 10) + array.NextDouble();
        Console.Write($"{Meow[i, j]:F1}\t");
    }
    Console.WriteLine();
}